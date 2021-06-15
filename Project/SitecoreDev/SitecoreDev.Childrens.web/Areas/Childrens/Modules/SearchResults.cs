using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreDev.Childrens.web.Areas.Childrens.Helpers.TemplatesFields;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Modules
{
    public class SearchResults
    {

        public virtual int PageNumber { get; set; }
        public virtual int FacetsPerCategory { get; set; }
        public virtual int ResultsPerPage { get; set; }
        public virtual int PagesToDisplay { get; set; }
        // Used for Pagination
        public bool ShowNavigation
        {
            get
            {
                return ((Results != null) && (Results.Count > 0));
            }
        }
        public bool ShowPrevious
        {
            get
            {
                return (PageNumber > 1);
            }
        }
        public bool ShowNext
        {
            get
            {
                return (PageNumber < TotalPages);
            }
        }
        public bool ShowFirst
        {
            get
            {
                return (PageNumber != 1);
            }
        }
        public bool ShowLast
        {
            get
            {
                return (PageNumber != TotalPages);
            }
        }
        public virtual int AvailableSteps { get { return (PagesToDisplay - 1); } }
        public virtual int TotalPages
        {
            get
            {
                return (int)Math.Ceiling(decimal.Divide(HitCount, ResultsPerPage));
            }
        }
        public virtual int LastPageStep
        {
            get
            {
                return (int)Math.Min(TotalPages, (PageNumber + AvailableSteps));
            }
        }
        public virtual int FirstPageStep
        {
            get
            {
                var step = PageNumber;
                // Last Page
                if (PageNumber == TotalPages)
                {
                    step = (int)Math.Max(1, PageNumber - AvailableSteps);
                }
                // Middle
                else if ((PageNumber + AvailableSteps) > TotalPages)
                {
                    step = PageNumber - ((PageNumber + AvailableSteps) - TotalPages);
                }
                // Anything else return page number //

                // Default fallback for any issues
                if (step <= 1)
                {
                    step = 1;
                }
                return step;
            }
        }
        // Used for Pagination
        public virtual int HitCount { get; set; }
        public virtual long ElapsedMilliseconds { get; set; }
        public virtual string SearchPhrase { get; set; }
        public virtual string EventMonth { get; set; }
        public virtual string Sort
        {
            get
            {
                if (SortDirection == SearchSort.CreateDate)
                {
                    return "date";
                }
                return "relevance";
            }
        }
        public virtual SearchSort SortDirection { get; set; }
        public virtual string PageType
        {
            get
            {
                if (Page == SearchPageType.Events)
                {
                    return PageFieldsMatcher.BasePage.PageTypes.Events;
                }
                else if (Page == SearchPageType.Providers)
                {
                    return PageFieldsMatcher.BasePage.PageTypes.Providers;
                }
                else if (Page == SearchPageType.Stories)
                {
                    return PageFieldsMatcher.BasePage.PageTypes.Stories;
                }
                return PageFieldsMatcher.BasePage.PageTypes.Resources;
            }
        }

        public virtual SearchPageType Page { get; set; }
        public virtual IList<MarcusSearchResultItem> Results { get; set; }
        public virtual IList<SearchResultCategory> FacetCategory { get; set; }
        public virtual IList<SearchResultsFacet> EventFacets { get; set; }
    }

    public enum SearchSort
    {
        Relevance,
        CreateDate
    }

    public enum SearchPageType
    {
        Resources,
        Events,
        Stories,
        Providers
    }

}