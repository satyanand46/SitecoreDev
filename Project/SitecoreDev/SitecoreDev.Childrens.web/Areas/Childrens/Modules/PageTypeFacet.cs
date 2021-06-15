using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Modules
{
    public class PageTypeFacet
    {
        public virtual string Title { get; set; }
        public virtual string PageType { get; set; }
        public virtual PageTypeCategory PrimaryFacet { get; set; }
        public virtual PageTypeCategory SecondaryFacet { get; set; }
        public virtual IList<QueryFacet> Facets
        {
            get
            {
                IList<QueryFacet> facets = new List<QueryFacet>();
                if ((PrimaryFacet != null) && (PrimaryFacet.Facets != null))
                {
                    foreach (var p in PrimaryFacet.Facets)
                    {
                        facets.Add(p);
                    }
                }

                if ((SecondaryFacet != null) && (SecondaryFacet.Facets != null))
                {
                    foreach (var p in SecondaryFacet.Facets)
                    {
                        facets.Add(p);
                    }
                }
                return (facets);
            }
        }
    }

    public class PageTypeCategory
    {
        public virtual string Title { get; set; }
        public virtual string FacetFolder { get; set; }
        public IList<QueryFacet> Facets { get; set; }
    }

    public class QueryFacet
    {
        public virtual string FieldName { get; set; }
        public virtual string FieldValue { get; set; }
    }
}
