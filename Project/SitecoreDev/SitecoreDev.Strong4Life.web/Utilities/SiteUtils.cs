using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace SitecoreDev.Strong4Life.web.Utilities
{
    public class SiteUtils
    {
        /// <summary>
        /// The site name
        /// </summary>
        public const string SiteName = "strong4life";

        /// <summary>
        /// Gets the twitter settings.
        /// </summary>
        /// <returns>Twitter Settings</returns>
        //public static TwitterSettings GetTwitterSettings()
        //{
        //    var consumerKey = Sitecore.Configuration.Settings.GetSetting("ConsumerKey");
        //    var consumerSecret = Sitecore.Configuration.Settings.GetSetting("ConsumerSecret");
        //    var accessToken = Sitecore.Configuration.Settings.GetSetting("AccessToken");
        //    var accessTokenSecret = Sitecore.Configuration.Settings.GetSetting("AccessTokenSecret");
        //    var authenticationVersion = Sitecore.Configuration.Settings.GetSetting("AuthenticationVersion");
        //    var authenticationSignatureMethod = Sitecore.Configuration.Settings.GetSetting("AuthenticationSignatureMethod");
        //    var resourceUrl = Sitecore.Configuration.Settings.GetSetting("ResourceUrl");
        //    var screenName = Sitecore.Configuration.Settings.GetSetting("ScreenName");
        //    var tweetsFile = Sitecore.Configuration.Settings.GetSetting("TweetsFile");

        //    var twitterSettings = new TwitterSettings(consumerKey, consumerSecret, accessToken, accessTokenSecret, authenticationVersion, authenticationSignatureMethod, resourceUrl, screenName, tweetsFile);

        //    return twitterSettings;
        //}

        /// <summary>
        /// Gets the search settings.
        /// </summary>
        /// <param name="database">The database.</param>
        /// <returns></returns>
        //public static SearchSettings GetSearchSettings(Database database)
        //{
        //    return GetSearchSettings(database, GetSearchSettingsPath());
        //}

        /// <summary>
        /// Gets the search settings.
        /// </summary>
        /// <param name="database">The database.</param>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        /// <exception cref="UtilityException">
        /// </exception>
        //public static SearchSettings GetSearchSettings(Database database, string path)
        //{
        //    if (null == database)
        //    {
        //        throw new UtilityException(Resources.ex_Database_Context);
        //    }

        //    try
        //    {
        //        var searchSettings = new SearchSettings();

        //        var searchSettingsItem = database.GetItem(path);

        //        searchSettings.DefaultSearchResultsPageUrl = string.Empty;

        //        if (searchSettingsItem.HasField(FieldUtils.SearchSettings.DefaultSearchResultsPage))
        //        {
        //            var searchResultsPageItemId = searchSettingsItem.Fields[FieldUtils.SearchSettings.DefaultSearchResultsPage].Value;

        //            if (!string.IsNullOrEmpty(searchResultsPageItemId))
        //            {
        //                var searchResultsPageItem = database.GetItem(ID.Parse(searchResultsPageItemId));

        //                searchSettings.DefaultSearchResultsPageUrl = searchResultsPageItem.Paths.ContextPath();
        //            }
        //        }

        //        searchSettings.SecondarySearchResultsPageUrl = string.Empty;

        //        if (searchSettingsItem.HasField(FieldUtils.SearchSettings.SecondarySearchResultsPage))
        //        {
        //            var searchResultsPageItemId = searchSettingsItem.Fields[FieldUtils.SearchSettings.SecondarySearchResultsPage].Value;

        //            if (!string.IsNullOrEmpty(searchResultsPageItemId))
        //            {
        //                var searchResultsPageItem = database.GetItem(ID.Parse(searchResultsPageItemId));

        //                searchSettings.SecondarySearchResultsPageUrl = searchResultsPageItem.Paths.ContextPath();
        //            }
        //        }

        //        if (searchSettingsItem.HasField(FieldUtils.SearchSettings.SearchTabs))
        //        {
        //            var searchTabIds = searchSettingsItem.Fields[FieldUtils.SearchSettings.SearchTabs].Values();

        //            foreach (string searchTabId in searchTabIds)
        //            {
        //                var searchTab = new SearchTab(searchTabId);

        //                var searchTabItem = database.GetItem(ID.Parse(searchTabId));

        //                if (searchTabItem.HasField(FieldUtils.SearchTab.Title))
        //                {
        //                    searchTab.Title = Convert.ToString(searchTabItem[FieldUtils.SearchTab.Title]).Trim().StripHtml();
        //                }

        //                searchTab.SearchResultsPageUrl = string.Empty;

        //                if (searchTabItem.HasField(FieldUtils.SearchTab.SearchResultsPage))
        //                {
        //                    var searchResultsPageItemId = searchTabItem.Fields[FieldUtils.SearchTab.SearchResultsPage].Value;

        //                    if (!string.IsNullOrEmpty(searchResultsPageItemId))
        //                    {
        //                        var searchResultsPageItem = database.GetItem(ID.Parse(searchResultsPageItemId));

        //                        searchTab.SearchResultsPageUrl = searchResultsPageItem.Paths.ContextPath();
        //                    }
        //                }

        //                searchTab.PageType = string.Empty;

        //                if (searchTabItem.HasField(FieldUtils.SearchTab.PageType))
        //                {
        //                    var pageTypeItemId = searchTabItem.Fields[FieldUtils.SearchTab.PageType].Value;

        //                    if (!string.IsNullOrEmpty(pageTypeItemId))
        //                    {
        //                        var pageTypeItem = database.GetItem(ID.Parse(pageTypeItemId));
        //                        searchTab.PageType = pageTypeItem.Name;
        //                    }
        //                }

        //                searchSettings.SearchTabs.Add(searchTab);
        //            }
        //        }

        //        if (searchSettingsItem.HasField(FieldUtils.SearchSettings.NoSearchResultsFoundMessage))
        //        {
        //            searchSettings.NoSearchResultsFoundMessage = new HtmlString(Convert.ToString(searchSettingsItem[FieldUtils.SearchSettings.NoSearchResultsFoundMessage]).Trim());
        //        }

        //        if (searchSettingsItem.HasField(FieldUtils.SearchSettings.MediaSearchRoot))
        //        {
        //            ReferenceField searchRoot = ((Sitecore.Data.Fields.ReferenceField)searchSettingsItem.Fields[FieldUtils.SearchSettings.MediaSearchRoot]);
        //            if ((searchRoot != null) && (searchRoot.TargetItem != null))
        //            {
        //                Item searchItem = database.GetItem(searchRoot.TargetItem.ID);
        //                if (searchItem != null)
        //                {
        //                    searchSettings.MediaSearchRoot = searchItem.Paths.FullPath;
        //                }
        //            }
        //        }

        //        return searchSettings;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new UtilityException(Resources.ex_Search_Settings, ex.InnerException);
        //    }
        //}

        /// <summary>
        /// Gets the site settings.
        /// </summary>
        /// <param name="database">The database.</param>
        /// <returns>Site Settings</returns>
        //public static SiteSettings GetSiteSettings(Database database)
        //{
        //    return GetSiteSettings(database, GetSiteSettingsPath());
        //}

        /// <summary>
        /// Gets the site settings.
        /// </summary>
        /// <param name="database">The database.</param>
        /// <param name="path">The path.</param>
        /// <returns>Site Settings</returns>
        /// <exception cref="UtilityException">
        /// </exception>
        //public static SiteSettings GetSiteSettings(Database database, string path)
        //{
        //    if (null == database)
        //    {
        //        throw new UtilityException(Resources.ex_Database_Context);
        //    }

        //    try
        //    {
        //        var siteSettings = new SiteSettings();

        //        var siteSettingsItem = database.GetItem(path);

        //        GenerateHeaderSettings(siteSettings, siteSettingsItem);
        //        GenerateFooterSettings(siteSettings, siteSettingsItem, database);
        //        GenerateSecondaryHeaderSettings(siteSettings, siteSettingsItem);
        //        GenerateSecondaryFooterSettings(siteSettings, siteSettingsItem, database);

        //        if (siteSettingsItem.HasField(FieldUtils.SiteSettings.PageNotFound))
        //        {
        //            var pageNotFoundId = siteSettingsItem.Fields[FieldUtils.SiteSettings.PageNotFound].Value;

        //            if (!string.IsNullOrEmpty(pageNotFoundId))
        //            {
        //                var pageNotFoundItem = database.GetItem(ID.Parse(pageNotFoundId));
        //                siteSettings.PageNotFoundUrl = pageNotFoundItem.Paths.ContextPath();
        //            }
        //            else
        //            {
        //                siteSettings.PageNotFoundUrl = string.Empty;
        //            }
        //        }

        //        if (siteSettingsItem.HasField(FieldUtils.SiteSettings.GoogleAnalyticsId))
        //        {
        //            siteSettings.GoogleAnalyticsId = Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.GoogleAnalyticsId]).Trim();
        //        }

        //        if (siteSettingsItem.HasField(FieldUtils.SiteSettings.DownloadImage))
        //        {
        //            siteSettings.DownloadImage = Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.DownloadImage]).Trim();
        //        }

        //        if (siteSettingsItem.HasField(FieldUtils.SiteSettings.ContactUs))
        //        {
        //            LinkField linkContactUs = (LinkField)siteSettingsItem.Fields[FieldUtils.SiteSettings.ContactUs];
        //            if (linkContactUs != null)
        //            {
        //                siteSettings.ContactUs.URL = linkContactUs.Url;
        //                siteSettings.ContactUs.LinkDescription = linkContactUs.Text;
        //                siteSettings.ContactUs.AlternateText = linkContactUs.Title;
        //            }
        //        }
        //        siteSettings.ScriptSource = Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.ScriptSource]).Trim();

        //        return siteSettings;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new UtilityException(Resources.ex_Site_Settings, ex.InnerException);
        //    }
        //}

        /// <summary>
        /// Generates the header settings.
        /// </summary>
        /// <param name="siteSettings">The site settings.</param>
        /// <param name="siteSettingsItem">The site settings item.</param>
        //public static void GenerateHeaderSettings(SiteSettings siteSettings, Item siteSettingsItem)
        //{
        //    siteSettings.PageTitleSuffix = Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.PageTitleSuffix]);

        //    ImageField desktopSiteLogoField = siteSettingsItem.Fields[FieldUtils.SiteSettings.DesktopSiteLogo];
        //    ImageField mobileSiteLogoField = siteSettingsItem.Fields[FieldUtils.SiteSettings.MobileSiteLogo];

        //    if (null != desktopSiteLogoField)
        //    {
        //        siteSettings.DesktopSiteLogoUrl = desktopSiteLogoField.MediaUrl();
        //        siteSettings.DesktopSiteLogoAlternateText = desktopSiteLogoField.AlternateText();
        //    }
        //    else
        //    {
        //        siteSettings.DesktopSiteLogoUrl = string.Empty;
        //        siteSettings.DesktopSiteLogoAlternateText = string.Empty;
        //    }

        //    if (null != mobileSiteLogoField)
        //    {
        //        siteSettings.MobileSiteLogoUrl = mobileSiteLogoField.MediaUrl();
        //        siteSettings.MobileSiteLogoAlternateText = mobileSiteLogoField.AlternateText();
        //    }
        //    else
        //    {
        //        siteSettings.MobileSiteLogoUrl = string.Empty;
        //        siteSettings.MobileSiteLogoAlternateText = string.Empty;
        //    }

        //    siteSettings.PrimaryNavigation = siteSettingsItem.Fields[FieldUtils.SiteSettings.PrimaryNavigation].Values();
        //    siteSettings.UtilityNavigation = siteSettingsItem.Fields[FieldUtils.SiteSettings.UtilityNavigation].Values();
        //}

        //public static void GenerateSecondaryHeaderSettings(SiteSettings siteSettings, Item siteSettingsItem)
        //{
        //    //siteSettings.PageTitleSuffix = Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.PageTitleSuffix]);

        //    ImageField desktopSiteLogoField = siteSettingsItem.Fields[FieldUtils.SiteSettings.SecondaryDesktopSiteLogo];
        //    ImageField mobileSiteLogoField = siteSettingsItem.Fields[FieldUtils.SiteSettings.SecondaryMobileSiteLogo];

        //    if (null != desktopSiteLogoField)
        //    {
        //        siteSettings.SecondaryDesktopSiteLogo = desktopSiteLogoField.MediaUrl();
        //        siteSettings.SecondaryDesktopSiteLogoAlternateText = desktopSiteLogoField.AlternateText();
        //    }
        //    else
        //    {
        //        siteSettings.SecondaryDesktopSiteLogo = string.Empty;
        //        siteSettings.SecondaryDesktopSiteLogoAlternateText = string.Empty;
        //    }

        //    if (null != mobileSiteLogoField)
        //    {
        //        siteSettings.SecondaryMobileSiteLogo = mobileSiteLogoField.MediaUrl();
        //        siteSettings.SecondaryMobileSiteLogoAlternateText = mobileSiteLogoField.AlternateText();
        //    }
        //    else
        //    {
        //        siteSettings.SecondaryMobileSiteLogo = string.Empty;
        //        siteSettings.SecondaryMobileSiteLogoAlternateText = string.Empty;
        //    }


        //    if (siteSettingsItem.HasField(FieldUtils.SiteSettings.Careers))
        //    {
        //        LinkField linkCareers = (LinkField)siteSettingsItem.Fields[FieldUtils.SiteSettings.Careers];
        //        if (linkCareers != null)
        //        {
        //            siteSettings.Careers.URL = linkCareers.Url;
        //            siteSettings.Careers.LinkDescription = linkCareers.Text;
        //            siteSettings.Careers.AlternateText = linkCareers.Title;
        //        }
        //    }

        //    if (siteSettingsItem.HasField(FieldUtils.SiteSettings.Donate))
        //    {
        //        LinkField linkDonate = (LinkField)siteSettingsItem.Fields[FieldUtils.SiteSettings.Donate];
        //        if (linkDonate != null)
        //        {
        //            siteSettings.Donate.URL = linkDonate.Url;
        //            siteSettings.Donate.LinkDescription = linkDonate.Text;
        //            siteSettings.Donate.AlternateText = linkDonate.Title;
        //        }
        //    }

        //    siteSettings.SecondaryPrimaryNavigation = siteSettingsItem.Fields[FieldUtils.SiteSettings.SecondaryPrimaryNavigation].Values();
        //    siteSettings.SecondaryUtilityNavigation = siteSettingsItem.Fields[FieldUtils.SiteSettings.SecondaryUtilityNavigation].Values();
        //    siteSettings.WantTo = Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.WantTo]).Trim();
        //    siteSettings.WantToLinks = siteSettingsItem.Fields[FieldUtils.SiteSettings.WantToLinks].Values();
        //    siteSettings.SearchPlaceholder = Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.SearchPlaceholder]).Trim();
        //    siteSettings.SearchPlaceholderMobile = Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.SearchPlaceholderMobile]).Trim();


        //    siteSettings.AlertEnabled = (Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.AlertEnabled]).Trim().Equals("1"));
        //    siteSettings.AlertBarColor = Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.AlertBarColor]).Trim();
        //    siteSettings.AlertTitle = Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.AlertTitle]).Trim();
        //    siteSettings.AlertHeadlineTitle = Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.AlertHeadlineTitle]).Trim();
        //    siteSettings.AlertShowIcon = (Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.AlertShowIcon]).Trim().Equals("1"));
        //    siteSettings.AlertCopy = Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.AlertCopy]).Trim();
        //    siteSettings.AlertsLinks = siteSettingsItem.Fields[FieldUtils.SiteSettings.AlertsLinks].Values();

        //    siteSettings.SecondarySocialConnections = siteSettingsItem.Fields[FieldUtils.SiteSettings.SecondarySocialConnections].Values();
        //}

        ///// <summary>
        ///// Generates the footer settings.
        ///// </summary>
        ///// <param name="siteSettings">The site settings.</param>
        ///// <param name="siteSettingsItem">The site settings item.</param>
        ///// <param name="database">The database.</param>
        //public static void GenerateFooterSettings(SiteSettings siteSettings, Item siteSettingsItem, Database database)
        //{
        //    siteSettings.SocialConnections = siteSettingsItem.Fields[FieldUtils.SiteSettings.SocialConnections].Values();
        //    siteSettings.ContactUsMethods = siteSettingsItem.Fields[FieldUtils.SiteSettings.ContactUsMethods].Values();

        //    siteSettings.Column1Links = siteSettingsItem.Fields[FieldUtils.SiteSettings.Column1Links].Values();
        //    siteSettings.Column2Links = siteSettingsItem.Fields[FieldUtils.SiteSettings.Column2Links].Values();
        //    siteSettings.Column3Links = siteSettingsItem.Fields[FieldUtils.SiteSettings.Column3Links].Values();

        //    siteSettings.Awards = siteSettingsItem.Fields[FieldUtils.SiteSettings.Awards].Values();

        //    if (!string.IsNullOrEmpty(Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.TermsOfUse]).Trim()))
        //    {
        //        var itemId = siteSettingsItem.Fields[FieldUtils.SiteSettings.TermsOfUse].Value;

        //        if (!string.IsNullOrEmpty(itemId))
        //        {
        //            var item = database.GetItem(ID.Parse(itemId));

        //            if (item.IsPageItem())
        //            {
        //                siteSettings.TermsOfUseTitle = Convert.ToString(item[FieldUtils.Page.DisplayName]).Trim().StripHtml();
        //                siteSettings.TermsOfUsePath = item.Paths.ContextPath();
        //                siteSettings.TermOfUseOpenInNewWindow = false;
        //            }
        //            else
        //            {
        //                var utilityLink = LinkUtils.GetUtilityLink(database, item);

        //                siteSettings.TermsOfUseTitle = utilityLink.Title.StripHtml();
        //                siteSettings.TermsOfUsePath = utilityLink.Path;
        //                siteSettings.TermOfUseOpenInNewWindow = utilityLink.OpenInNewWindow;
        //            }
        //        }
        //    }

        //    if (!string.IsNullOrEmpty(Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.PatientPrivacy]).Trim()))
        //    {
        //        var itemId = siteSettingsItem.Fields[FieldUtils.SiteSettings.PatientPrivacy].Value;

        //        if (!string.IsNullOrEmpty(itemId))
        //        {
        //            var item = database.GetItem(ID.Parse(itemId));

        //            if (item.IsPageItem())
        //            {
        //                siteSettings.PatientPrivacyTitle = Convert.ToString(item[FieldUtils.Page.DisplayName]).Trim().StripHtml();
        //                siteSettings.PatientPrivacyPath = item.Paths.ContextPath();
        //                siteSettings.PatientPrivacyOpenInNewWindow = false;
        //            }
        //            else
        //            {
        //                var utilityLink = LinkUtils.GetUtilityLink(database, item);

        //                siteSettings.PatientPrivacyTitle = utilityLink.Title.StripHtml();
        //                siteSettings.PatientPrivacyPath = utilityLink.Path;
        //                siteSettings.PatientPrivacyOpenInNewWindow = utilityLink.OpenInNewWindow;
        //            }
        //        }
        //    }


        //    if (!string.IsNullOrEmpty(Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.StatementOfDiscrimination]).Trim()))
        //    {
        //        var itemId = siteSettingsItem.Fields[FieldUtils.SiteSettings.StatementOfDiscrimination].Value;

        //        if (!string.IsNullOrEmpty(itemId))
        //        {
        //            var item = database.GetItem(ID.Parse(itemId));

        //            if (item.IsPageItem())
        //            {
        //                siteSettings.StatementOfDiscriminationTitle = Convert.ToString(item[FieldUtils.Page.DisplayName]).Trim().StripHtml();
        //                siteSettings.StatementOfDiscriminationPath = item.Paths.ContextPath();
        //                siteSettings.StatementOfDiscriminationOpenInNewWindow = false;
        //            }
        //            else
        //            {
        //                var utilityLink = LinkUtils.GetUtilityLink(database, item);

        //                siteSettings.StatementOfDiscriminationTitle = utilityLink.Title.StripHtml();
        //                siteSettings.StatementOfDiscriminationPath = utilityLink.Path;
        //                siteSettings.StatementOfDiscriminationOpenInNewWindow = utilityLink.OpenInNewWindow;
        //            }
        //        }
        //    }

        //    siteSettings.Copyright = Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.Copyright]).Trim();
        //}

        //public static void GenerateSecondaryFooterSettings(SiteSettings siteSettings, Item siteSettingsItem, Database database)
        //{
        //    siteSettings.SecondarySocialConnections = siteSettingsItem.Fields[FieldUtils.SiteSettings.SecondarySocialConnections].Values();
        //    siteSettings.SecondaryContactUsMethods = siteSettingsItem.Fields[FieldUtils.SiteSettings.SecondaryContactUsMethods].Values();

        //    siteSettings.SecondaryColumn1Links = siteSettingsItem.Fields[FieldUtils.SiteSettings.SecondaryColumn1Links].Values();
        //    siteSettings.SecondaryColumn2Links = siteSettingsItem.Fields[FieldUtils.SiteSettings.SecondaryColumn2Links].Values();
        //    siteSettings.SecondaryColumn3Links = siteSettingsItem.Fields[FieldUtils.SiteSettings.SecondaryColumn3Links].Values();

        //    siteSettings.SecondaryAwards = siteSettingsItem.Fields[FieldUtils.SiteSettings.SecondaryAwards].Values();

        //    if (!string.IsNullOrEmpty(Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.SecondaryTermsOfUse]).Trim()))
        //    {
        //        var itemId = siteSettingsItem.Fields[FieldUtils.SiteSettings.SecondaryTermsOfUse].Value;

        //        if (!string.IsNullOrEmpty(itemId))
        //        {
        //            var item = database.GetItem(ID.Parse(itemId));

        //            if (item.IsPageItem())
        //            {
        //                siteSettings.SecondaryTermsOfUseTitle = Convert.ToString(item[FieldUtils.Page.DisplayName]).Trim().StripHtml();
        //                siteSettings.SecondaryTermsOfUsePath = item.Paths.ContextPath();
        //                siteSettings.SecondaryTermOfUseOpenInNewWindow = false;
        //            }
        //            else
        //            {
        //                var utilityLink = LinkUtils.GetUtilityLink(database, item);

        //                siteSettings.SecondaryTermsOfUseTitle = utilityLink.Title.StripHtml();
        //                siteSettings.SecondaryTermsOfUsePath = utilityLink.Path;
        //                siteSettings.SecondaryTermOfUseOpenInNewWindow = utilityLink.OpenInNewWindow;
        //            }
        //        }
        //    }

        //    if (!string.IsNullOrEmpty(Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.SecondaryPatientPrivacy]).Trim()))
        //    {
        //        var itemId = siteSettingsItem.Fields[FieldUtils.SiteSettings.SecondaryPatientPrivacy].Value;

        //        if (!string.IsNullOrEmpty(itemId))
        //        {
        //            var item = database.GetItem(ID.Parse(itemId));

        //            if (item.IsPageItem())
        //            {
        //                siteSettings.SecondaryPatientPrivacyTitle = Convert.ToString(item[FieldUtils.Page.DisplayName]).Trim().StripHtml();
        //                siteSettings.SecondaryPatientPrivacyPath = item.Paths.ContextPath();
        //                siteSettings.SecondaryPatientPrivacyOpenInNewWindow = false;
        //            }
        //            else
        //            {
        //                var utilityLink = LinkUtils.GetUtilityLink(database, item);

        //                siteSettings.SecondaryPatientPrivacyTitle = utilityLink.Title.StripHtml();
        //                siteSettings.SecondaryPatientPrivacyPath = utilityLink.Path;
        //                siteSettings.SecondaryPatientPrivacyOpenInNewWindow = utilityLink.OpenInNewWindow;
        //            }
        //        }
        //    }


        //    if (!string.IsNullOrEmpty(Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.SecondaryStatementOfDiscrimination]).Trim()))
        //    {
        //        var itemId = siteSettingsItem.Fields[FieldUtils.SiteSettings.SecondaryStatementOfDiscrimination].Value;

        //        if (!string.IsNullOrEmpty(itemId))
        //        {
        //            var item = database.GetItem(ID.Parse(itemId));

        //            if (item.IsPageItem())
        //            {
        //                siteSettings.SecondaryStatementOfDiscriminationTitle = Convert.ToString(item[FieldUtils.Page.DisplayName]).Trim().StripHtml();
        //                siteSettings.SecondaryStatementOfDiscriminationPath = item.Paths.ContextPath();
        //                siteSettings.SecondaryStatementOfDiscriminationOpenInNewWindow = false;
        //            }
        //            else
        //            {
        //                var utilityLink = LinkUtils.GetUtilityLink(database, item);

        //                siteSettings.SecondaryStatementOfDiscriminationTitle = utilityLink.Title.StripHtml();
        //                siteSettings.SecondaryStatementOfDiscriminationPath = utilityLink.Path;
        //                siteSettings.SecondaryStatementOfDiscriminationOpenInNewWindow = utilityLink.OpenInNewWindow;
        //            }
        //        }
        //    }

        //    siteSettings.SecondaryCopyright = Convert.ToString(siteSettingsItem[FieldUtils.SiteSettings.SecondaryCopyright]).Trim();
        //}

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