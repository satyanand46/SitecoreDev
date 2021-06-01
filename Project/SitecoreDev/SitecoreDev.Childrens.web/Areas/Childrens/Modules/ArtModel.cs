
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Modules
{
    public class ArtModel : IRenderingModel
    {
       public HtmlString Title { get; set; }
        public HtmlString Description { get; set; }
        public Sitecore.Mvc.Presentation.Rendering Rendering { get; set; }
        public Item Item { get; set; }
        public Item PageItem { get; set; }
        public void Initialize(Sitecore.Mvc.Presentation.Rendering rendering)
        {
            Rendering = rendering;
            Item = rendering.Item;
            PageItem = PageContext.Current.Item;

            Title = new HtmlString(FieldRenderer.Render(Item,"Title"));
            Description = new HtmlString(FieldRenderer.Render(Item, "Description"));
        }
    }
}