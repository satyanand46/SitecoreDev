using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Modules
{
    public class SearchResultCategory
    {
        public virtual string Name { get; set; }
        public virtual string Value { get; set; }
        public virtual IList<SearchResultsFacet> Facets { get; set; }
    }

    public class SearchResultsFacet
    {
        public virtual string Name { get; set; }
        public virtual string Value { get; set; }
        public virtual int Count { get; set; }
        public virtual bool Selected { get; set; }
    }
}