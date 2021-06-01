using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.XA.Foundation.RenderingVariants.Models;

namespace SocialComponents.Models
{
    public class SocialFeedListModel : VariantListsRenderingModel
    {
        public List<SocialFeedItemModel> SocialFeedListItems { get; set; }
        public List<SocialFeedItemModel> TwitterFeedListItems { get; set; }
        public List<SocialFeedItemModel> InstagramFeedListItems { get; set; }
        public List<SocialFeedItemModel> FacebookFeedListItems { get; set; }
        public List<SocialFeedItemModel> YoutubeListItems { get; set; }
        public List<SocialFeedItemModel> LinkedInListItems { get; set; }
        public string TwitterRedirectURLTitle { get; set; }
        public string TwitterAuth { get; set; }
        public string TwitterScreenName { get; set; }
        public string InstagramAccessToken { get; set; }
        public string TwitterRedirectURL { get; set; }
        public string Title { get; set; }
        public string InstagramRedirectURL { get; set; }
        public string InstagramRedirectURLTitle { get; set; }
        public string FacebookRedirectURL { get; internal set; }
        public string FacebookRedirectURLTitle { get; internal set; }
        public string YouTubeRedirectURL { get; internal set; }
        public string YoutubeRedirectURLTitle { get; internal set; }
        public string LinkedInRedirectURL { get; internal set; }
        public string LinkedInRedirectURLTitle { get; internal set; }

    }
}