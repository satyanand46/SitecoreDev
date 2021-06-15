using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Modules
{
    public class SiteSettings
    {

        public virtual Item Context { get; set; }
        public virtual string SiteName { get; set; }
        public virtual ImageField DefaultImage { get; set; }
        public virtual ReferenceField HomePage { get; set; }
        public virtual ReferenceField PageNotFound { get; set; }
        public virtual ReferenceField SearchResultsPage { get; set; }
        public virtual ReferenceField SearchRoot { get; set; }
        public virtual ReferenceField MediaSearchRoot { get; set; }
        public virtual LinkField DonateUrl { get; set; }
        public virtual string LaunchPixel { get; set; }
        public virtual IList<string> IndexableMediaDocument { get; set; }
    }
}