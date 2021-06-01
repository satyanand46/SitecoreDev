using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using System.Collections.Generic;

namespace SitecoreDev.Strong4Life.web.Models
{
    public class SearchModel : SearchResultItem
    {
        [IndexField("_name")]
        public virtual string ItemName { get; set; }

        [IndexField("heading_t")]
        public virtual string Heading { get; set; }

        [IndexField("sub_heading_t")]
        public virtual string SubHeading { get; set; }

        [IndexField("description_t")]
        public virtual string Description {get; set;}
            [IndexField("name_t")]
            public virtual string Title { get; set; }
    }


    public class SearchResult
    {
        public string Title { get; set; }
        public string Heading { get; set; }
        public string SubHeading { get; set; }
        public string Description { get; set; }
    }

    /// <summary>
    /// Custom search result model for binding to front end
    /// </summary>
    public class SearchResults
    {
        public List<SearchResult> Results { get; set; }
    }
}