using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SocialComponents.Repositories;
using Sitecore.XA.Foundation.RenderingVariants;
using Sitecore.XA.Foundation.RenderingVariants.Controllers.Base;

namespace SocialComponents.Controllers
{
    public class SocialfeedsController : PaginableController
    {
        protected ISocialFeedItemRepository SocialFeedItemRepository
        { get; set; }
        protected ISocialFeedListRepository SocialFeedListRepository
        { get; set; }


        public SocialfeedsController()
        {


        }


        public SocialfeedsController(ISocialFeedListRepository Repository)
        {
            SocialFeedListRepository = Repository;


        }
        protected override object GetModel()
        {
            //string test = null;


            //test.ToLower();
            SocialFeedListRepository = new SocialFeedListRepository();
            return SocialFeedListRepository.GetModel();
        }

    }
}