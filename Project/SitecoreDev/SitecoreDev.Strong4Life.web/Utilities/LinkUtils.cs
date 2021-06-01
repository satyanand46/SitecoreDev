using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Data.Fields;
using SitecoreDev.Strong4Life.web.Properties;
using SitecoreDev.Strong4Life.web.Extensions;

namespace SitecoreDev.Strong4Life.web.Utilities
{
    public class LinkUtils
    {
        /// <summary>
        /// Gets the utility link.
        /// </summary>
        /// <param name="database">The database.</param>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        /// <exception cref="Choa.Org.Common.Utilities.UtilityException">
        /// Database Context Cannot Be NULL.
        /// or
        /// Item Cannot Be NULL.
        /// or
        /// Item Not A Utility Link Item.
        /// or
        /// Unable To Retrieve Utility Link For The Site.
        /// </exception>
        public static UtilityLink GetUtilityLink(Database database, Item item)
        {
            if (null == database)
            {
                throw new UtilityException(Resources.ex_Database_Context);
            }

            if (null == item)
            {
                throw new UtilityException(Resources.ex_Item_Cannot_Be_Null);
            }

            if (!item.IsUtilityLinkItem())
            {
                throw new UtilityException(Resources.ex_Not_A_Valid_Utility_Link_Item);
            }

            LinkField linkField = item.Fields[FieldUtils.UtilityLink.Link];

            var title = Convert.ToString(item[FieldUtils.UtilityLink.Title]).Trim();
            var iconKey = Convert.ToString(item[FieldUtils.UtilityLink.IconKey]).Trim();
            var path = linkField.Url;
            //var openInNewWindow = linkField.OpenInNewWindow();

            if (!string.IsNullOrEmpty(iconKey))
            {
                if (iconKey.ToLower().StartsWith("<image"))
                {
                    iconKey = string.Empty;
                }
                else if (!iconKey.ToLower().StartsWith("fa fa-"))
                {
                    if (!iconKey.ToLower().StartsWith("icon-"))
                    {
                        iconKey = string.Format("icon-{0}", iconKey);
                    }
                }
            }

            var utilityLink = new UtilityLink(title, path, iconKey, true);

            return utilityLink;
        }
    }
}