using System.Web.Mvc;
using SitecoreDev.Childrens.web.Areas.Childrens.Modules;
using System.Web.Http;
using System.Net.Http;
using Sitecore.Mvc.Presentation;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Controllers
{
    public class CircuitController : Controller
    {            

        // GET: Childrens/Circuit
        public ActionResult Featured()
        {
            Circuit crt = new Circuit();
            crt.Initialize(RenderingContext.Current.Rendering);

            return View("~/Areas/Childrens/Views/Circuit/Featured.cshtml", crt);
        }
    }
}