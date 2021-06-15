using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.ContentSearch;
using SitecoreDev.Childrens.web.Areas.Childrens.Modules;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Interfaces
{
    public interface ISearchResultsService
    {
        SearchResults GetResults(SearchQuery query);
    }
}