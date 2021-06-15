using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using SitecoreDev.Childrens.web.Areas.Childrens.Helpers.TemplatesFields;
using SitecoreDev.Childrens.web.Areas.Childrens.Interfaces;
using SitecoreDev.Childrens.web.Areas.Childrens.Modules;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Services
{
    public class SearchResultsService : ISearchResultsService
    {
        private readonly ISearchIndexService _searchIndexService;
        private readonly ILinkManager _linkManager;
        private readonly SiteSettings _siteSettings;
        private readonly Childrens.Marcus.Org.Domain.Models.SearchSettings _searchSettings;

        public SearchResultsService(ISearchIndexService searchIndexService, ILinkManager linkManager, ISettingsService settingService)
        {
            if (searchIndexService == null)
            {
                throw new ArgumentNullException("searchIndexService");
            }

            if (linkManager == null)
            {
                throw new ArgumentNullException("linkManager");
            }

            if (settingService == null)
            {
                throw new ArgumentNullException("settingService");
            }

            _searchIndexService = searchIndexService;
            _linkManager = linkManager;
            _siteSettings = settingService.GetSiteSettings();
            _searchSettings = settingService.GetSearchSettings();
        }

        public SearchResults GetResults(SearchQuery searchQuery)
        {
            Assert.ArgumentCondition((searchQuery.CurrentPage >= 0), "CurrentPage", "Page Number should be greater than 0");

            SearchResults results = null;
            ISearchIndex searchIndex = _searchIndexService.GetSearchIndex();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            using (IProviderSearchContext context = searchIndex.CreateSearchContext())
            {
                var queryable = CreateAndInitializeQuery(context);
                queryable = AddContentPredicates(queryable, searchQuery);
                queryable = AddEventPredicates(queryable, searchQuery);
                queryable = AddPageType(queryable, searchQuery);
                queryable = AddFacets(queryable, searchQuery);
                queryable = AddFacetsEvents(queryable, searchQuery);
                queryable = AddSorting(queryable, searchQuery);
                queryable = AddPagination(queryable, searchQuery);

                // Fetch Results -- This must be done inside of the using statement
                //               -- the context is disposed and hits will throw exeception.
                SearchResults<ContentSearchResultItem> searchResultItems = queryable.GetResults<ContentSearchResultItem>();
                results = BuildResults(searchResultItems, searchQuery);
            }
            stopwatch.Stop();

            results.ElapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            return results;
        }

        private SearchResults BuildResults(SearchResults<ContentSearchResultItem> searchResults, SearchQuery query)
        {
            SearchResults results = new SearchResults()
            {
                FacetCategory = new List<SearchResultCategory>(),
                Results = new List<MarcusSearchResultItem>(),
                PageNumber = query.CurrentPage,
                ResultsPerPage = _searchSettings.ResultsPerPage,
                SearchPhrase = query.QueryText,
                SortDirection = query.SortDirection,
                PagesToDisplay = _searchSettings.StepCount,
                Page = query.Page,
                FacetsPerCategory = _searchSettings.FacetsToDisplay,
                EventMonth = query.EventMonth,
            };

            foreach (var hit in searchResults.Hits)
            {
                MarcusSearchResultItem result = new MarcusSearchResultItem()
                {
                    Context = hit.Document.Context,
                    Relevancy = (double)hit.Score,
                    PageUrl = string.IsNullOrEmpty(hit.Document.ExternalLink) == false ? hit.Document.ExternalLink : hit.Document.FriendlyUrl,
                    UrlTarget = string.IsNullOrEmpty(hit.Document.ExternalLink) == false ? hit.Document.Context.LinkFieldTarget(PageFieldsMatcher.BasePage.Fields.SearchExternalLink) : string.Empty,
                    ContentDate = hit.Document.CreatedDate,
                    NavigationTitle = hit.Document.NavigationTitle,
                    PageTitle = hit.Document.PageTitle,
                    PageDescription = hit.Document.PageDescription,
                };

                if ((_siteSettings.MediaSearchRoot != null) &&
                    (_siteSettings.MediaSearchRoot.TargetItem != null) &&
                    (query.Page == SearchPageType.Resources) &&
                    (hit.Document.Paths.Contains(_siteSettings.MediaSearchRoot.TargetItem.ID)))
                {
                    string title = string.Empty;
                    if (string.IsNullOrWhiteSpace(hit.Document.Title) == false)
                    {
                        title = hit.Document.Title;
                    }
                    else if (string.IsNullOrWhiteSpace(hit.Document.DisplayName) == false)
                    {
                        title = hit.Document.DisplayName;
                    }
                    result.PageTitle = title;
                    result.PageDescription = string.IsNullOrWhiteSpace(hit.Document.Description) ? string.Empty : hit.Document.Description;
                    result.PageUrl = hit.Document.Url;
                }
                results.Results.Add(result);
            }
            results.FacetCategory = BuildResultsFacets(searchResults, query, results.PageType);
            results.EventFacets = BuildEventFacets(searchResults, query, results.PageType);
            results.HitCount = searchResults.TotalSearchResults;
            return results;
        }

        private IList<SearchResultsFacet> BuildEventFacets(SearchResults<ContentSearchResultItem> searchResults, SearchQuery query, string pageType)
        {
            IList<SearchResultsFacet> results = new List<SearchResultsFacet>();

            if (pageType == PageFieldsMatcher.BasePage.PageTypes.Events)
            {
                var category = searchResults.Facets.Categories.FirstOrDefault(c => c.Name == PageFieldsMatcher.BasePage.FieldNames.EventStartMonth);
                if (category != null)
                {
                    foreach (var val in category.Values)
                    {
                        SearchResultsFacet facet = new SearchResultsFacet()
                        {
                            Name = category.Name,
                            Value = val.Name,
                            Count = val.AggregateCount,
                            Selected = string.IsNullOrWhiteSpace(query.EventMonth) ? false : query.EventMonth.Trim().ToLower() == val.Name,
                        };
                        results.Add(facet);
                    }
                }

                category = searchResults.Facets.Categories.FirstOrDefault(c => c.Name == PageFieldsMatcher.BasePage.FieldNames.EventEndMonth);
                if (category != null)
                {
                    foreach (var val in category.Values)
                    {
                        SearchResultsFacet facet = new SearchResultsFacet()
                        {
                            Name = category.Name,
                            Value = val.Name,
                            Count = val.AggregateCount,
                            Selected = string.IsNullOrWhiteSpace(query.EventMonth) ? false : query.EventMonth.Trim().ToLower() == val.Name,
                        };
                        results.Add(facet);
                    }
                }
            }
            return results;
        }

        private IList<SearchResultCategory> BuildResultsFacets(SearchResults<ContentSearchResultItem> searchResults, SearchQuery query, string pageType)
        {
            var response = new List<SearchResultCategory>();

            PageTypeFacet pageTypeFacets = _searchSettings.Facets.FirstOrDefault(f => f.PageType == pageType);
            if (pageTypeFacets != null)
            {
                var primary = pageTypeFacets.PrimaryFacet;
                if (primary != null)
                {
                    SearchResultCategory resultsCategory = new SearchResultCategory()
                    {
                        Name = primary.Title,
                        Value = primary.FacetFolder,
                        Facets = new List<SearchResultsFacet>(),
                    };

                    if (primary.Facets != null)
                    {
                        foreach (var facet in primary.Facets)
                        {
                            int hitCount = 0;
                            if ((searchResults.Facets != null) && (searchResults.Facets.Categories != null))
                            {
                                var category = searchResults.Facets.Categories.FirstOrDefault(c => c.Name == primary.FacetFolder);
                                if (category != null)
                                {
                                    var value = category.Values.FirstOrDefault(v => v.Name == facet.FieldValue);
                                    if (value != null)
                                    {
                                        hitCount = value.AggregateCount;
                                    }
                                }
                            }
                            SearchResultsFacet srf = new SearchResultsFacet()
                            {
                                Name = facet.FieldName,
                                Value = facet.FieldValue,
                                Count = hitCount,
                                Selected = query.Facets != null && query.Facets.ContainsKey(primary.FacetFolder) && query.Facets[primary.FacetFolder].Contains(facet.FieldValue),
                            };
                            resultsCategory.Facets.Add(srf);
                        }
                    }
                    response.Add(resultsCategory);
                }

                var secondary = pageTypeFacets.SecondaryFacet;
                if (secondary != null)
                {
                    SearchResultCategory resultsCategory = new SearchResultCategory()
                    {
                        Name = secondary.Title,
                        Value = secondary.FacetFolder,
                        Facets = new List<SearchResultsFacet>(),
                    };

                    if (secondary.Facets != null)
                    {
                        foreach (var facet in secondary.Facets)
                        {
                            int hitCount = 0;
                            if ((searchResults.Facets != null) && (searchResults.Facets.Categories != null))
                            {
                                var category = searchResults.Facets.Categories.FirstOrDefault(c => c.Name == secondary.FacetFolder);
                                if (category != null)
                                {
                                    var value = category.Values.FirstOrDefault(v => v.Name == facet.FieldValue);
                                    if (value != null)
                                    {
                                        hitCount = value.AggregateCount;
                                    }
                                }
                            }
                            SearchResultsFacet srf = new SearchResultsFacet()
                            {
                                Name = facet.FieldName,
                                Value = facet.FieldValue,
                                Count = hitCount,
                                Selected = query.Facets != null && query.Facets.ContainsKey(secondary.FacetFolder) && query.Facets[secondary.FacetFolder].Contains(facet.FieldValue),
                            };
                            resultsCategory.Facets.Add(srf);
                        }
                    }
                    response.Add(resultsCategory);
                }
            }
            return response;
        }

        #region Initialize
        private IQueryable<ContentSearchResultItem> CreateAndInitializeQuery(IProviderSearchContext context)
        {
            var queryable = context.GetQueryable<ContentSearchResultItem>();
            queryable = SetQueryRoots(queryable);
            queryable = FilterOnHasShowInSearchResults(queryable);
            queryable = FilterOnLanguage(queryable);
            queryable = FilterOnVersion(queryable);
            return queryable;
        }

        private IQueryable<ContentSearchResultItem> FilterOnHasShowInSearchResults(IQueryable<ContentSearchResultItem> queryable)
        {
            return queryable.Filter(item => (item.ShowInSearchResults == true).Boost(0));
        }

        private IQueryable<ContentSearchResultItem> FilterOnLanguage(IQueryable<ContentSearchResultItem> queryable)
        {
            queryable = queryable.Filter(item => item.Language == Context.Language.Name);
            return queryable;
        }

        private IQueryable<ContentSearchResultItem> FilterOnVersion(IQueryable<ContentSearchResultItem> queryable)
        {
            queryable = queryable.Cast<ContentSearchResultItem>().Filter(item => item.IsLatestVersion);
            return queryable;
        }

        private IQueryable<ContentSearchResultItem> SetQueryRoots(IQueryable<ContentSearchResultItem> queryable)
        {
            var includePredicate = PredicateBuilder.False<ContentSearchResultItem>();

            // Update for: https://community.sitecore.net/developers/f/5/t/4398
            if ((_siteSettings.SearchRoot != null) && (_siteSettings.SearchRoot.TargetItem != null))
            {
                includePredicate = includePredicate.Or(item => item.Paths.Contains(_siteSettings.SearchRoot.TargetItem.ID).Boost(0));
            }

            if ((_siteSettings.MediaSearchRoot != null) && (_siteSettings.MediaSearchRoot.TargetItem != null))
            {
                includePredicate = includePredicate.Or(item => item.Paths.Contains(_siteSettings.MediaSearchRoot.TargetItem.ID).Boost(0));
            }
            return queryable.Where(includePredicate);
        }
        #endregion

        #region Build
        private IQueryable<ContentSearchResultItem> AddContentPredicates(IQueryable<ContentSearchResultItem> queryable, SearchQuery searchQuery)
        {
            var containsQuery = PredicateBuilder.True<ContentSearchResultItem>();
            if (string.IsNullOrWhiteSpace(searchQuery.QueryText) == false)
            {
                var tokens = searchQuery.QueryText.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var token in tokens)
                {
                    var currentToken = token.ToLower();
                    containsQuery = containsQuery
                        .Or(item => item.Name.Contains(currentToken))
                        .Or(item => item.Keywords.Contains(currentToken))
                        .Or(item => item.PageDescription.Contains(currentToken))
                        .Or(item => item.PageTitle.Contains(currentToken))
                        .Or(item => item.NavigationTitle.Contains(currentToken))
                        .Or(item => item.Title.Contains(currentToken))
                        .Or(item => item.Description.Contains(currentToken))
                        .Or(item => item.Content.Contains(currentToken));
                }
                queryable = queryable.Where(containsQuery);
            }
            return queryable;
        }

        private IQueryable<ContentSearchResultItem> AddEventPredicates(IQueryable<ContentSearchResultItem> queryable, SearchQuery searchQuery)
        {
            if (searchQuery.Page == SearchPageType.Events)
            {
                DateTime nextYear = DateTime.Now.AddYears(1);
                DateTime lastYear = DateTime.Today.AddYears(-1);

                // Get all events 1 year before today and 1 year after
                var rangeQuery = PredicateBuilder.True<ContentSearchResultItem>();
                rangeQuery = rangeQuery.And(x => x.EventStart.Between(lastYear, nextYear, Inclusion.Both) ||
                                                 x.EventEnd.Between(lastYear, nextYear, Inclusion.Both));
                if (string.IsNullOrWhiteSpace(searchQuery.EventMonth) == false)
                {
                    rangeQuery = rangeQuery.And(x => x.EventStartMonth == searchQuery.EventMonth ||
                                                     x.EventEndMonth == searchQuery.EventMonth);
                }
                queryable = queryable.Where(rangeQuery);
            }
            return queryable;
        }

        private IQueryable<ContentSearchResultItem> AddFacets(IQueryable<ContentSearchResultItem> queryable, SearchQuery searchQuery)
        {
            var addedFacetPredicate = false;
            var facetPredicate = PredicateBuilder.True<ContentSearchResultItem>();
            if ((_searchSettings.Facets != null) && (_searchSettings.Facets.Any() == true))
            {
                var pageTypeFacets = _searchSettings.Facets.FirstOrDefault(f => f.PageType == searchQuery.PageType);
                if ((pageTypeFacets != null) && (pageTypeFacets.Facets != null))
                {
                    if ((pageTypeFacets.PrimaryFacet != null) && (string.IsNullOrEmpty(pageTypeFacets.PrimaryFacet.FacetFolder) == false))
                    {
                        if (searchQuery.Facets.ContainsKey(pageTypeFacets.PrimaryFacet.FacetFolder))
                        {
                            var facetValues = searchQuery.Facets[pageTypeFacets.PrimaryFacet.FacetFolder].Where(f => string.IsNullOrWhiteSpace(f) == false);
                            var facetValuePredicate = PredicateBuilder.False<ContentSearchResultItem>();
                            if ((facetValues != null) && (facetValues.Any() == true))
                            {
                                foreach (var facetValue in facetValues)
                                {
                                    facetValuePredicate = facetValuePredicate.Or(item => item[pageTypeFacets.PrimaryFacet.FacetFolder] == facetValue);
                                }
                                facetPredicate = facetPredicate.And(facetValuePredicate);
                                addedFacetPredicate = true;
                            }
                        }
                        queryable = queryable.FacetOn(item => item[pageTypeFacets.PrimaryFacet.FacetFolder]);
                    }

                    if ((pageTypeFacets.SecondaryFacet != null) && (string.IsNullOrEmpty(pageTypeFacets.SecondaryFacet.FacetFolder) == false))
                    {
                        if (searchQuery.Facets.ContainsKey(pageTypeFacets.SecondaryFacet.FacetFolder))
                        {
                            var facetValues = searchQuery.Facets[pageTypeFacets.SecondaryFacet.FacetFolder].Where(f => string.IsNullOrWhiteSpace(f) == false);
                            var facetValuePredicate = PredicateBuilder.False<ContentSearchResultItem>();
                            if ((facetValues != null) && (facetValues.Any() == true))
                            {
                                foreach (var facetValue in facetValues)
                                {
                                    facetValuePredicate = facetValuePredicate.Or(item => item[pageTypeFacets.SecondaryFacet.FacetFolder] == facetValue);
                                }
                                facetPredicate = facetPredicate.And(facetValuePredicate);
                                addedFacetPredicate = true;
                            }
                        }
                        queryable = queryable.FacetOn(item => item[pageTypeFacets.SecondaryFacet.FacetFolder]);
                    }
                }
            }
            if (addedFacetPredicate == true)
            {
                queryable = queryable.Where(facetPredicate);
            }
            return queryable;
        }

        private IQueryable<ContentSearchResultItem> AddFacetsEvents(IQueryable<ContentSearchResultItem> queryable, SearchQuery searchQuery)
        {
            if (searchQuery.Page == SearchPageType.Events)
            {
                queryable = queryable.FacetOn(item => item.EventStartMonth)
                                     .FacetOn(item => item.EventEndMonth);
            }
            return queryable;
        }

        private IQueryable<ContentSearchResultItem> AddPagination(IQueryable<ContentSearchResultItem> queryable, SearchQuery searchQuery)
        {
            return queryable.Page(searchQuery.CurrentPage <= 0 ? 0 : searchQuery.CurrentPage - 1,
                                  _searchSettings.ResultsPerPage <= 0 ? 10 : _searchSettings.ResultsPerPage);
        }

        private IQueryable<ContentSearchResultItem> AddPageType(IQueryable<ContentSearchResultItem> queryable, SearchQuery searchQuery)
        {
            var pageTypePredicate = PredicateBuilder.True<ContentSearchResultItem>();
            if (searchQuery.Page == SearchPageType.Events)
            {
                pageTypePredicate = pageTypePredicate.Or(item => (item.PageType == PageFieldsMatcher.BasePage.PageTypes.Events).Boost(0));
            }
            else if (searchQuery.Page == SearchPageType.Providers)
            {
                pageTypePredicate = pageTypePredicate.Or(item => (item.PageType == PageFieldsMatcher.BasePage.PageTypes.Providers).Boost(0));
            }
            else if (searchQuery.Page == SearchPageType.Stories)
            {
                pageTypePredicate = pageTypePredicate.Or(item => (item.PageType == PageFieldsMatcher.BasePage.PageTypes.Stories).Boost(0));
            }
            else
            {
                pageTypePredicate = pageTypePredicate.Or(item => (item.PageType == PageFieldsMatcher.BasePage.PageTypes.Resources).Boost(0));
            }
            queryable = queryable.Where(pageTypePredicate);
            return queryable;
        }

        private IQueryable<ContentSearchResultItem> AddSorting(IQueryable<ContentSearchResultItem> queryable, SearchQuery searchQuery)
        {
            if (searchQuery.SortDirection == SearchSort.CreateDate)
            {
                // Due to the format of the date string, this is swapped to descending
                return queryable.OrderByDescending(i => i.CreatedDate);
            }
            return queryable;
        }
        #endregion
    }
    }