using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.XA.Foundation.IoC;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;
using SocialComponents.Models;

namespace SocialComponents.Repositories
{
    public class SocialFeedListRepository : ListRepository, ISocialFeedListRepository, IModelRepository, IControllerRepository, IAbstractRepository<IRenderingModelBase>
    {

        private IEnumerable<SocialFeedItemModel> _socialFeedListItems;


        public IEnumerable<SocialFeedItemModel> SocialFeedListItems
        {
            get
            {

                List<SocialFeedItemModel> socialFeeds = new List<SocialFeedItemModel>();

                //Removed code to fill in the Social Feed, this is just a request through the REST Endpoint 
                return _socialFeedListItems;
            }
        }

      

        public override IRenderingModelBase GetModel()
        {
            //instanitate the social feed list model
            SocialFeedListModel model = new SocialFeedListModel();
            model.Title = GetFieldValue("Title");
            model.TwitterAuth = GetFieldValue("TwitterAuth");
            model.TwitterScreenName = GetFieldValue("TwitterScreenName");
            model.InstagramAccessToken = GetFieldValue("InstagramAccessToken");
            model.TwitterRedirectURL = GetFieldValue("TwitterRedirectURL");
            model.TwitterRedirectURLTitle = GetFieldValue("TwitterRedirectURLTitle");
            model.InstagramRedirectURL = GetFieldValue("InstagramRedirectURL");
            model.InstagramRedirectURLTitle = GetFieldValue("InstagramRedirectURLTitle");


            model.FacebookRedirectURL = GetFieldValue("FacebookRedirectURL");
            model.FacebookRedirectURLTitle = GetFieldValue("FacebookRedirectURLTitle");
            model.YouTubeRedirectURL = GetFieldValue("YouTubeRedirectURL");
            model.YoutubeRedirectURLTitle = GetFieldValue("YoutubeRedirectURLTitle");
            model.LinkedInRedirectURL = GetFieldValue("LinkedInRedirectURL");
            model.LinkedInRedirectURLTitle = GetFieldValue("LinkedInRedirectURLTitle");


            this.FillBaseProperties((object)model);
            //Get the different social feeds
            model.SocialFeedListItems = this.SocialFeedListItems.ToList();
            //model.TwitterFeedListItems = this.TwitterFeedListItems.ToList();
            //model.InstagramFeedListItems = this.InstagramFeedListItems.ToList();
            //model.FacebookFeedListItems = this.FacebookFeedListItems.ToList();
            //model.YoutubeListItems = this.YoutubeFeedListItems.ToList();
            //model.LinkedInListItems = this.LinkedInListItems.ToList();


            return (IRenderingModelBase)model;


        }

        //Do a null check before returning the field value

        private string GetFieldValue(string fieldName)
        {
            if (Rendering != null && Rendering.DataSourceItem != null && Rendering.DataSourceItem.Fields[fieldName] != null && Rendering.DataSourceItem.Fields[fieldName].Value != null)
            {
                return Rendering.DataSourceItem.Fields[fieldName].Value;
            }
            return "";
        }

    }
}