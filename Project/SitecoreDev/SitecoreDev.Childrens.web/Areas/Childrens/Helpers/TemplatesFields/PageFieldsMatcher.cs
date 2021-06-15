using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Helpers.TemplatesFields
{
    public static class PageFieldsMatcher
    {
        public static class BasePage
        {
            public static readonly ID ID = new ID("{ED2D34A4-4248-4F88-BC96-6ED3626136A6}");

            public static class FieldNames
            {
                public const string SeoDescription = "description";
                public const string SeoKeywords = "keywords";
                public const string SeoTitle = "title";
                public const string PageTitle = "page_title";
                public const string NavigationTitle = "navigation_title";
                public const string ShowInSearchResults = "show_in_search_results";
                public const string IsLatestVersion = "_latestversion";
                public const string HasPresentation = "has_presentation";
                public const string ContentType = "content_type";
                public const string PageType = "pagetype";
                public const string EventCategories = "eventcategory";
                public const string EventTypes = "eventtype";
                public const string ProgramsServices = "programsservices";
                public const string ProviderSpecialties = "providerspecialty";
                public const string ResourceTypes = "resourcetype";
                public const string StoryCategories = "storycategory";

                public const string EventTitle = "eventtitle";
                public const string EventDescription = "eventdescription";
                public const string EventCtaTitle = "eventctatitle";
                public const string EventCtaUrl = "eventctaurl";
                public const string EventStart = "eventstart";
                public const string EventEnd = "eventend";
                public const string EventStartMonth = "eventstart_month";
                public const string EventEndMonth = "eventend_month";
                public const string ExternalLink = "external_link";

                public const string MediaTitle = "title";
                public const string MediaDescription = "description";
                public const string MediaDisplayName = "_displayname";
                public const string MediaKeywords = "keywords";
            }

            public static class PageTypes
            {
                public const string Events = "event";
                public const string Providers = "provider";
                public const string Stories = "story";
                public const string Resources = "resource";
            }

            public static class Fields
            {
                public static readonly ID PageTitle = new ID("{B793F679-358E-4505-AD1B-264FF0778A58}");
                public static readonly ID ThumbnailImage = new ID("{2F242960-B1D7-4FA8-B3FE-2D0ADE537E65}");
                public static readonly ID ShowInSearchResults = new ID("{B5784987-0A8F-4F83-8BB1-442605BE3B25}");
                public static readonly ID AllowSharing = new ID("{0B2223DB-26EE-4DE4-ADE2-977A6875A6EC}");
                public static readonly ID OpenGraphPageType = new ID("{008EA1DE-E3A7-4696-8674-14C30645309B}");
                public static readonly ID SeoTitle = new ID("{3E0CD08D-726D-418C-9326-71E581E6F01A}");
                public static readonly ID SeoKeywords = new ID("{A51C51CF-FD99-4380-AE29-472DD565B166}");
                public static readonly ID SeoDescription = new ID("{6A314035-F3C8-4788-98E0-0FAF86A6AA66}");
                public static readonly ID NoIndex = new ID("{B341E89C-E14B-4944-A037-04AAD685D89C}");
                public static readonly ID NoFollow = new ID("{006FCD36-E3A1-486B-B2D3-BFF49830A436}");
                public static readonly ID NavigationTitle = new ID("{2D6C98C4-CBF6-418F-92A0-B35EDC27266F}");
                public static readonly ID ShowInNavigation = new ID("{8F66B909-95E0-40F0-9448-1D279CAF468D}");
                public static readonly ID ShowInSitemap = new ID("{450F8127-F45D-4C77-A86E-B6AC944C8724}");
                public static readonly ID ShowInFeaturedLinks = new ID("{98F2D26E-2F4B-495D-8587-4A4F92E13FD5}");
                public static readonly ID ShowInTertiaryNavigation = new ID("{D2101ABE-03AC-4228-86BC-1C7ADCE24728}");
                public static readonly ID PageType = new ID("{8452E087-70DA-4EDB-B858-A16F21889677}");
                public static readonly ID EventCategories = new ID("{291A9376-3F00-4CAA-88D8-6CB3BFD131BE}");
                public static readonly ID EventTypes = new ID("{388F13B0-6FFF-489E-A9B8-9F9438D53767}");
                public static readonly ID ProgramsServices = new ID("{955BBAD5-45DA-44B2-88AE-C98DD78BEFA6}");
                public static readonly ID ProviderSpecialties = new ID("{C1224B22-7426-4BAE-9675-978A83CF36C7}");
                public static readonly ID ResourceTypes = new ID("{35CD7067-205A-4C63-AACF-F16AD14F8418}");
                public static readonly ID StoryCategories = new ID("{1E46EA37-2D84-49A0-A434-E028A0BE97C9}");
                public static readonly ID SearchResultsImage = new ID("{5503FC4F-9B7A-4153-B56E-364CC85CE103}");
                public static readonly ID SearchExternalLink = new ID("{AE49A8ED-C66F-48B2-A424-F369BBFBB264}");
                public static readonly ID SearchBoost = new ID("{A0640BB2-3BAA-4BB4-8CB7-D9AE35563BC6}");
            }
        }
    }
}