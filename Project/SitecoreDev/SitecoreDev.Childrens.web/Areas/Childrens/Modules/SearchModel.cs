using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using System.Collections.Generic;


namespace SitecoreDev.Childrens.web.Areas.Childrens.Modules
{
    public class SearchModel : SearchResultItem
    {
        [IndexField("_name")]
        public virtual string ItemName { get; set; }

        [IndexField("description_t")]
        public virtual string Description { get; set; }
        [IndexField("name_t")]
        public virtual string Title { get; set; }
        [IndexField("title_t")]
        public virtual string fName { get; set; }
        [IndexField("body_t")]
        public virtual string fbody { get; set; }
    }

    public class SearchResult
    {
        public string Title { get; set; }      
        public string Description { get; set; }
        public string fName { get; set; }
        public string fbody { get; set; }
    }

    /// <summary>
    /// Custom search result model for binding to front end
    /// </summary>
    public class SearchResults
    {
        public List<SearchResult> Results { get; set; }
    }
}