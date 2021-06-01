using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;
using Sitecore.Pipelines;

namespace SitecoreDev.Strong4Life.web.s4lPipeline
{
    // TODO: \App_Config\include\RegisterCustomRoute.config created automatically when creating RegisterCustomRoute class.

    public class RegisterCustomRoute
    {
        public virtual void Process(PipelineArgs args)
        {
            Register();
        }
        public static void Register()
        {
            RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            RouteTable.Routes.MapRoute("CustomRoute", "api/testing/{controller}/{action}");
        }
    }
}