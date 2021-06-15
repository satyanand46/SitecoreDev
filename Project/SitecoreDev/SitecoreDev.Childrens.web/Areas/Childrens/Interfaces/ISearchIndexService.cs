using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.ContentSearch;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Interfaces
{
    public interface ISearchIndexService
    {
        ISearchIndex GetSearchIndex();
    }
}