using System;
using System.Collections.Generic;
using System.Text;

namespace Choa.Strong4Life.DataContracts
{
    public class Article : SitecoreComponent
    {
        public virtual string Title { get; set; }
        public virtual string ImagePath { get; set; }
        public virtual string ImageAlt { get; set; }
        public virtual string CoreContent { get; set; }
        public virtual string Date { get; set; }
        public virtual string Author { get; set; }
        public virtual string AuthorLink { get; set; }
        public virtual Boolean InPageLink { get; set; }
        public virtual Boolean ShowDivider { get; set; }
    }
}
