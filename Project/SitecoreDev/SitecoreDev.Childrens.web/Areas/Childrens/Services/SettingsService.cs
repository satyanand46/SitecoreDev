using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreDev.Childrens.web.Areas.Childrens.Interfaces;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Services
{
    public class SettingsService : ISettingsService
    {
        private readonly ISiteRepository _siteRepository;

        public SettingsService(ISiteRepository siteRepository)
        {
            if (siteRepository == null)
            {
                throw new ArgumentNullException("siteRepository");
            }

            _siteRepository = siteRepository;
        }

        //public SearchSettings GetSearchSettings()
        //{
        //    SearchSettings settings = null;
        //    Item root = _siteRepository.GetSearchSettingsItem();
        //    if (root != null)
        //    {
        //        settings = new SearchSettings()
        //        {
        //            Context = root,
        //            ResultsPerPage = root.GetInteger(SiteFieldsMatcher.SearchSettingsRoot.Fields.ResultsPerPage),
        //            StepCount = root.GetInteger(SiteFieldsMatcher.SearchSettingsRoot.Fields.StepCount),
        //            FacetsToDisplay = root.GetInteger(SiteFieldsMatcher.SearchSettingsRoot.Fields.FacetsToDisplay),
        //            MediaReferenceType = ((Sitecore.Data.Fields.ReferenceField)root.Fields[SiteFieldsMatcher.SearchSettingsRoot.Fields.MediaPageType]),
        //            Facets = GetFacets(),
        //        };
        //    }
        //    return settings;
        //}

        //public IList<PageTypeFacet> GetFacets()
        //{
        //    IList<PageTypeFacet> systemFacets = new List<PageTypeFacet>();
        //    Item root = _siteRepository.GetPageTypeRootItem();
        //    if ((root != null) && (root.Children != null))
        //    {
        //        foreach (Item pageType in root.Children)
        //        {
        //            if (pageType.IsDerived(SiteFieldsMatcher.PageType.ID) == true)
        //            {
        //                PageTypeFacet facet = new PageTypeFacet()
        //                {
        //                    Title = pageType[SiteFieldsMatcher.FacetItem.Fields.Text],
        //                    PageType = pageType[SiteFieldsMatcher.FacetItem.Fields.Value],
        //                };

        //                Item primary = pageType.ReferencedFieldItem(SiteFieldsMatcher.PageType.Fields.PrimaryCategory);
        //                if ((primary != null) &&
        //                    (primary.IsDerived(SiteFieldsMatcher.FacetFolder.ID) == true) &&
        //                    (primary.Children != null))
        //                {
        //                    facet.PrimaryFacet = new PageTypeCategory()
        //                    {
        //                        Title = primary.Name,
        //                        FacetFolder = primary[SiteFieldsMatcher.FacetFolder.Fields.Key],
        //                        Facets = new List<QueryFacet>(),
        //                    };

        //                    foreach (Item primaryFacet in primary.Children)
        //                    {
        //                        facet.PrimaryFacet.Facets.Add(new QueryFacet()
        //                        {
        //                            FieldName = primaryFacet[SiteFieldsMatcher.FacetItem.Fields.Text],
        //                            FieldValue = primaryFacet[SiteFieldsMatcher.FacetItem.Fields.Value],
        //                        });
        //                    }
        //                }

        //                Item secondary = pageType.ReferencedFieldItem(SiteFieldsMatcher.PageType.Fields.SecondaryCategory);
        //                if ((secondary != null) &&
        //                    (secondary.IsDerived(SiteFieldsMatcher.FacetFolder.ID) == true) &&
        //                    (secondary.Children != null))
        //                {
        //                    facet.SecondaryFacet = new PageTypeCategory()
        //                    {
        //                        Title = secondary.Name,
        //                        FacetFolder = secondary[SiteFieldsMatcher.FacetFolder.Fields.Key],
        //                        Facets = new List<QueryFacet>(),
        //                    };

        //                    foreach (Item secondaryFacet in secondary.Children)
        //                    {
        //                        facet.SecondaryFacet.Facets.Add(new QueryFacet()
        //                        {
        //                            FieldName = secondaryFacet[SiteFieldsMatcher.FacetItem.Fields.Text],
        //                            FieldValue = secondaryFacet[SiteFieldsMatcher.FacetItem.Fields.Value],
        //                        });
        //                    }
        //                }

        //                systemFacets.Add(facet);
        //            }
        //        }
        //    }
        //    return systemFacets;
        //}

        //public SiteSettings GetSiteSettings()
        //{
        //    SiteSettings settings = null;
        //    Item root = _siteRepository.GetSiteSettingsItem();
        //    if (root != null)
        //    {
        //        settings = new SiteSettings()
        //        {
        //            Context = root,
        //            SiteName = ((Sitecore.Data.Fields.TextField)root.Fields[SiteFieldsMatcher.SiteSettings.Fields.SiteName]).Value,
        //            DefaultImage = ((Sitecore.Data.Fields.ImageField)root.Fields[SiteFieldsMatcher.SiteSettings.Fields.DefaultImage]),
        //            HomePage = ((Sitecore.Data.Fields.ReferenceField)root.Fields[SiteFieldsMatcher.SiteSettings.Fields.HomePage]),
        //            PageNotFound = ((Sitecore.Data.Fields.ReferenceField)root.Fields[SiteFieldsMatcher.SiteSettings.Fields.PageNotFound]),
        //            SearchResultsPage = ((Sitecore.Data.Fields.ReferenceField)root.Fields[SiteFieldsMatcher.SiteSettings.Fields.SearchResultsPage]),
        //            SearchRoot = ((Sitecore.Data.Fields.ReferenceField)root.Fields[SiteFieldsMatcher.SiteSettings.Fields.SearchRoot]),
        //            MediaSearchRoot = ((Sitecore.Data.Fields.ReferenceField)root.Fields[SiteFieldsMatcher.SiteSettings.Fields.MediaSearchRoot]),
        //            DonateUrl = ((Sitecore.Data.Fields.LinkField)root.Fields[SiteFieldsMatcher.SiteSettings.Fields.DonatePage]),
        //            LaunchPixel = ((Sitecore.Data.Fields.TextField)root.Fields[SiteFieldsMatcher.AnalyticsSettings.Fields.LaunchPixel]).Value,
        //            IndexableMediaDocument = new List<string>(),
        //        };

        //        Item documents = _siteRepository.GetDocumentTypesRootItem();
        //        if ((documents != null) && (documents.Children != null) && (documents.Children.Any() == true))
        //        {
        //            foreach (Item document in documents.Children)
        //            {
        //                if (document.IsDerived(SiteFieldsMatcher.IndexableDocument.ID) == true)
        //                {
        //                    string doc = document[SiteFieldsMatcher.FacetItem.Fields.Value];
        //                    if (string.IsNullOrWhiteSpace(doc) == false)
        //                    {
        //                        settings.IndexableMediaDocument.Add(doc);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return settings;
        //}

        //public ShareComponentSettings GetShareComponentSettings()
        //{
        //    ShareComponentSettings settings = null;
        //    Item root = _siteRepository.GetSiteSettingsItem();
        //    if (root != null)
        //    {
        //        settings = new ShareComponentSettings()
        //        {
        //            Context = root,
        //            Title = ((Sitecore.Data.Fields.TextField)root.Fields[ShareComponentFieldMatcher.Title]).Value,
        //            ShareCTAText = ((Sitecore.Data.Fields.TextField)root.Fields[ShareComponentFieldMatcher.ShareCta]).Value,
        //            SocialModalHeading = ((Sitecore.Data.Fields.TextField)root.Fields[ShareComponentFieldMatcher.SocialModalHeading]).Value,
        //            AddThisScriptSrc = ((Sitecore.Data.Fields.TextField)root.Fields[ShareComponentFieldMatcher.AddThisScriptSrc]).Value,
        //        };
        //    }
        //    return settings;
        //}

        //public IList<NavigationItem> GetNavigation(Item settings, ID navigationField, int maxlevels = 0)
        //{
        //    IList<NavigationItem> links = new List<NavigationItem>();

        //    IEnumerable<Item> navigationLinks = settings.GetMultiListValueItems(navigationField);
        //    if (navigationLinks != null)
        //    {
        //        foreach (Item item in navigationLinks)
        //        {
        //            NavigationItem navigationItem = GetNavigationItem(item, maxlevels);
        //            links.Add(navigationItem);
        //        }
        //    }
        //    return links;
        //}

        //public NavigationItem GetNavigationItem(Item item, int maxlevels = 0)
        //{
        //    NavigationItem navigationItem = new NavigationItem()
        //    {
        //        Context = item,
        //        Url = item.Url(),
        //        Target = "",
        //        Children = new List<NavigationItem>(),
        //    };

        //    if ((maxlevels - 1) > 0)
        //    {
        //        if (item.Children != null)
        //        {
        //            foreach (Item child in item.Children)
        //            {
        //                NavigationItem navItemChild = GetNavigationItem(child, maxlevels - 1);
        //                navigationItem.Children.Add(navItemChild);
        //            }
        //        }
        //    }
        //    return navigationItem;
        //}

        //private IList<UtilityLink> GetUtilityLinks(Item root, ID fieldID)
        //{
        //    IList<UtilityLink> links = new List<UtilityLink>();
        //    var utilityLinks = root.GetMultiListValueItems(fieldID);
        //    if (utilityLinks != null)
        //    {
        //        foreach (Item item in utilityLinks)
        //        {
        //            links.Add(new UtilityLink()
        //            {
        //                Context = item,
        //                Title = ((Sitecore.Data.Fields.TextField)root.Fields[SiteFieldsMatcher.UtilityLink.Fields.Title]).Value,
        //                Link = ((Sitecore.Data.Fields.LinkField)root.Fields[SiteFieldsMatcher.UtilityLink.Fields.LinkUrl]),
        //            });
        //        }
        //    }
        //    return (links);
        //}

        //private IList<SocialSharing> GetSocialSharing(Item root, ID fieldID)
        //{
        //    IList<SocialSharing> links = new List<SocialSharing>();
        //    var socialShares = root.GetMultiListValueItems(fieldID);
        //    if (socialShares != null)
        //    {
        //        foreach (Item item in socialShares)
        //        {
        //            links.Add(new SocialSharing()
        //            {
        //                Context = item,
        //                ShareUrl = (root.Fields[SiteFieldsMatcher.SocialShareSettings.Fields.ShareUrl]).Value,
        //                ShareClass = (root.Fields[SiteFieldsMatcher.SocialShareSettings.Fields.ShareClass]).Value,
        //            });
        //        }
        //    }

        //    return links;
        //}
    }
}