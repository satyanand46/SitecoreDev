using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.XA.Foundation.Variants.Abstractions.Models;

namespace SocialComponents.Models
{
    public class SocialFeedItemModel : VariantsRenderingModel
    {
        public string Text { get; set; }
        public string ScreenName { get; set; }
        public string CreatedAt { get; set; }
        public string URL { get; internal set; }
        public string Type { get; internal set; }
        public string redirectURL { get; set; }


    }
}