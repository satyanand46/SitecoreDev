using System.Web;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Modules
{
    public class Circuit : RenderingModel
    {
        public HtmlString Name
        {
            get
            {
                return new HtmlString(FieldRenderer.Render(this.Item, "Name"));
            }
        }

        public HtmlString Text
        {
            get
            {
                return new HtmlString(FieldRenderer.Render(this.Item, "Text"));
            }
        }
    }
}