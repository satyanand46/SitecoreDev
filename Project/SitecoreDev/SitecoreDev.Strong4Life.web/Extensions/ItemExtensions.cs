
using Sitecore.Data.Items;
using SitecoreDev.Strong4Life.web.Utilities;

namespace SitecoreDev.Strong4Life.web.Extensions
{
    public static class ItemExtensions
    {
        /// <summary>
        /// Determines whether [is childrens item].
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static bool IsChildrensItem(this Item item)
        {
            return item.Paths.Path.ToLower().StartsWith(SiteUtils.GetSiteRootPath()) || item.Paths.Path.ToLower().StartsWith(SiteUtils.GetMediaFilesPath()) || item.Paths.Path.ToLower().StartsWith(SiteUtils.GetMediaImagesPath());
        }        

        /// <summary>
        /// Determines whether the item has field.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>True or False</returns>
        public static bool HasField(this Item item, string fieldName)
        {
            if (string.IsNullOrEmpty(fieldName))
            {
                return false;
            }

            return null != item.Fields[fieldName];
        }
       

        /// <summary>
        /// Determines whether the item is utility link item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>True or False</returns>
        /// 
        public static bool IsUtilityLinkItem(this Item item)
        {
            return IsUtilityLinkItemChoa(item) || IsUtilityLinkItemEnhancement(item);
        }

        public static bool IsUtilityLinkItemChoa(this Item item)
        {
            return item.HasField(FieldUtils.UtilityLink.Title) && item.HasField(FieldUtils.UtilityLink.Link) && item.HasField(FieldUtils.UtilityLink.IconKey);
        }

        public static bool IsUtilityLinkItemEnhancement(this Item item)
        {
            return item.Template.FullName.Contains("User Defined/Childrens/Global/Component Templates/Utility Link");
        }

    }
}