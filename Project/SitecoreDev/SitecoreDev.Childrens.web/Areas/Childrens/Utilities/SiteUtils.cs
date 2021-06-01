using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Utilities
{
    public class SiteUtils
    {
        /// <summary>
        /// The site name
        /// </summary>
        public const string SiteName = "childrens";

        

        /// <summary>
        /// Gets the site root path.
        /// </summary>
        /// <returns>Site Root Path</returns>
        public static string GetSiteRootPath()
        {
            return Sitecore.Configuration.Factory.GetSite(SiteName).RootPath.ToLower();
        }

        /// <summary>
        /// Gets the site home path.
        /// </summary>
        /// <returns></returns>
        public static string GetSiteHomePath()
        {
            return string.Format("{0}{1}", GetSiteRootPath(), Sitecore.Configuration.Factory.GetSite(SiteName).StartItem.ToLower());
        }

        /// <summary>
        /// Gets the Doctors Folder path.
        /// </summary>
        /// <returns></returns>
        public static string GetDoctorsFolderPath()
        {
            return string.Format("{0}{1}", GetSiteRootPath(), Sitecore.Configuration.Settings.GetSetting("DoctorFolderPath").ToLower());
        }

        /// <summary>
        /// Gets the site settings path.
        /// </summary>
        /// <returns></returns>
        public static string GetSiteSettingsPath()
        {
            return string.Format("{0}{1}", GetSiteRootPath(), Sitecore.Configuration.Settings.GetSetting("SiteSettingsPath").ToLower());
        }

        /// <summary>
        /// Gets the search settings path.
        /// </summary>
        /// <returns></returns>
        public static string GetSearchSettingsPath()
        {
            return string.Format("{0}{1}", GetSiteRootPath(), Sitecore.Configuration.Settings.GetSetting("SearchSettingsPath").ToLower());
        }

        /// <summary>
        /// Gets the site components path.
        /// </summary>
        /// <returns></returns>
        public static string GetSiteComponentsPath()
        {
            return string.Format("{0}{1}", GetSiteRootPath(), Sitecore.Configuration.Settings.GetSetting("SiteComponentsPath").ToLower());
        }

        /// <summary>
        /// Gets the site aliases path.
        /// </summary>
        /// <returns></returns>
        public static string GetSiteAliasesPath()
        {
            return string.Format("{0}{1}", GetSiteRootPath(), Sitecore.Configuration.Settings.GetSetting("AliasesPath").ToLower());
        }

        /// <summary>
        /// Gets the site forms path.
        /// </summary>
        /// <returns></returns>
        public static string GetSiteFormsPath()
        {
            return string.Format("{0}{1}", GetSiteRootPath(), Sitecore.Configuration.Settings.GetSetting("FormsPath").ToLower());
        }

        /// <summary>
        /// Gets the media files path.
        /// </summary>
        /// <returns></returns>
        public static string GetMediaFilesPath()
        {
            return Sitecore.Configuration.Settings.GetSetting("ChildrensMediaFilesPath").ToLower();
        }

        /// <summary>
        /// Gets the media images path.
        /// </summary>
        /// <returns></returns>
        public static string GetMediaImagesPath()
        {
            return Sitecore.Configuration.Settings.GetSetting("ChildrensMediaImagesPath").ToLower();
        }

        /// <summary>
        /// Gets the forms placeholder key.
        /// </summary>
        /// <returns></returns>
        public static string GetFormsPlaceholderKey()
        {
            return Sitecore.Configuration.Settings.GetSetting("ChildrensFormsPlaceholderKey");
        }

        /// <summary>
        /// Gets the physician photos path.
        /// </summary>
        /// <returns></returns>
        public static string GetPhysicianPhotosPath()
        {
            return Sitecore.Configuration.Settings.GetSetting("ChildrensPhysicianPhotosPath").ToLower();
        }

        /// <summary>
        /// Gets the search crawler user agent.
        /// </summary>
        /// <returns></returns>
        public static string GetSearchCrawlerUserAgent()
        {
            return Sitecore.Configuration.Settings.GetSetting("ChildrensSearchCrawlerUserAgent");
        }

        /// <summary>
        /// Gets the tiki toki mobile service URL.
        /// </summary>
        /// <returns></returns>
        public static string GetTikiTokiMobileServiceUrl()
        {
            return Sitecore.Configuration.Settings.GetSetting("TikiTokiMobileServiceUrl").TrimEnd('/');
        }

        /// <summary>
        /// Gets the tiki toki desktop service URL.
        /// </summary>
        /// <returns></returns>
        public static string GetTikiTokiDesktopServiceUrl()
        {
            return Sitecore.Configuration.Settings.GetSetting("TikiTokiDesktopServiceUrl").TrimEnd('/');
        }

        /// <summary>
        /// Gets the stay well database connection string.
        /// </summary>
        /// <returns></returns>
        public static string GetStayWellDatabaseConnectionString()
        {
            return Sitecore.Configuration.Settings.GetConnectionString("staywell");
        }

        public static string GetSpecialtyFolderPath()
        {
            return string.Format("{0}{1}", GetSiteRootPath(), Sitecore.Configuration.Settings.GetSetting("DoctorSpecialtyFolderPath").ToLower());
        }
    }
}