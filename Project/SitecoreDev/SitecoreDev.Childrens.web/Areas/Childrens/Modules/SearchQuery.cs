using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreDev.Childrens.web.Areas.Childrens.Helpers.TemplatesFields;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Modules
{
    public class SearchQuery
    {
        public virtual IDictionary<string, string[]> Facets { get; set; }
        public virtual string QueryText { get; set; }
        public virtual int CurrentPage { get; set; }
        public virtual string Sort { get; set; }
        public virtual string PageType { get; set; }
        public virtual string EventMonth { get; set; }
        public virtual SearchSort SortDirection
        {
            get
            {
                if (string.IsNullOrEmpty(Sort) == false && Sort.ToLower() == "date")
                {
                    return SearchSort.CreateDate;
                }
                return SearchSort.Relevance;
            }
        }
        public virtual SearchPageType Page
        {
            get
            {
                if (string.IsNullOrEmpty(PageType) == false && PageType.ToLower() == PageFieldsMatcher.BasePage.PageTypes.Events)
                {
                    return SearchPageType.Events;
                }
                else if (string.IsNullOrEmpty(PageType) == false && PageType.ToLower() == PageFieldsMatcher.BasePage.PageTypes.Providers)
                {
                    return SearchPageType.Providers;
                }
                else if (string.IsNullOrEmpty(PageType) == false && PageType.ToLower() == PageFieldsMatcher.BasePage.PageTypes.Stories)
                {
                    return SearchPageType.Stories;
                }
                return SearchPageType.Resources;
            }
        }
    }
}