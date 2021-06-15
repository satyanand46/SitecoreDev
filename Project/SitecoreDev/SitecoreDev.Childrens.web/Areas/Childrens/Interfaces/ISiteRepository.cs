using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data.Items;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Interfaces
{
    public interface ISiteRepository
    {
        Item GetPageTypeRootItem();
        Item GetDocumentTypesRootItem();
        Item GetFacetRootItem();
        Item GetSiteHomeItem();
        Item GetSiteRootItem();
        Item GetComponentRootItem();
        Item GetSiteSettingsItem();
        Item GetSearchSettingsItem();
    }
}
