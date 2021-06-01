using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SocialComponents.Repositories;


namespace SocialComponents.Pipeline.IoC
{
    public class RegisterSocialFeedsServices: IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {


            serviceCollection.AddTransient<ISocialFeedItemRepository, SocialFeedItemRepository>();
            serviceCollection.AddTransient<ISocialFeedListRepository, SocialFeedListRepository>();

        }

    
    }
}