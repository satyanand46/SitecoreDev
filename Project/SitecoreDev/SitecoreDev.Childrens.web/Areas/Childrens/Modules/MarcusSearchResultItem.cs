using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Sitecore.Data.Items;
using SitecoreDev.Childrens.web.Areas.Childrens.Extensions;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Modules
{
    public class MarcusSearchResultItem
    {
        private const string Seperator = " > ";

        public virtual BreadcrumbItems ItemHeirarchy { get; set; }
        public virtual string BreadCrumb
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                //foreach (var item in ItemHeirarchy.Items)
                //{
                //    builder.Append(item.Title);
                //    builder.Append(Seperator);
                //}
                return builder.ToString().TrimEnd(Seperator);
            }
        }

        public virtual Item Context { get; set; }
        public virtual double Relevancy { get; set; }
        public virtual DateTime ContentDate { get; set; }
        public virtual string PageUrl { get; set; }
        public virtual string UrlTarget { get; set; }
        public virtual string NavigationTitle { get; set; }
        public virtual string PageTitle { get; set; }
        public virtual string PageDescription { get; set; }
        public virtual SearchPageType ResultType { get; set; }
    }
}