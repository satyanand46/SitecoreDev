using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.XA.Foundation.IoC;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;

namespace SocialComponents.Repositories
{
    public interface ISocialFeedListRepository : IModelRepository, IControllerRepository, IAbstractRepository<IRenderingModelBase>
    {
    }
}