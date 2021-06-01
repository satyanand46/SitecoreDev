using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SocialComponents.Models;
using Sitecore.XA.Foundation.Variants.Abstractions.Models;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;

namespace SocialComponents.Repositories
{
    public class SocialFeedItemRepository : VariantsRepository, ISocialFeedItemRepository
    {
        public SocialFeedItemRepository()
        { }


        public override IRenderingModelBase GetModel()
        {
            SocialFeedItemModel model = new SocialFeedItemModel();
            FillBaseProperties(model);
            return model;
        }

    }
}