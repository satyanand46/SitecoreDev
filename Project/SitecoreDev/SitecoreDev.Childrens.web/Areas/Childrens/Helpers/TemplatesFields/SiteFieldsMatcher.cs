using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Helpers.TemplatesFields
{
    public static class SiteFieldsMatcher
    {
        public static class SiteRoot
        {
            public static readonly ID ID = new ID("{CE294636-D739-465F-87E4-FC99DE857474}");
            public static readonly string SiteName = "Marcus_Redesign";
            public static readonly string SitePath = "/sitecore/content/Marcus Center";
        }

        public static class SiteHomePage
        {
            public static readonly ID ID = new ID("{E80338A6-1A13-434D-A7A6-EEC7C2B7ECAB}");
        }

        public static class SiteComponentsRoot
        {
            public static readonly ID ID = new ID("{8E41B056-258E-4BF1-B832-8372A765D085}");
        }

        public static class SearchSettingsRoot
        {
            public static readonly ID ID = new ID("{0F69459D-EFD5-43E3-9BE0-6AC0FEE96429}");

            public static class Fields
            {
                public static readonly ID ResultsPerPage = new ID("{B44243EA-8ED6-4560-8DBA-DBC2CF2FED28}");
                public static readonly ID StepCount = new ID("{D4A1C50D-83B1-482D-833E-9A7240876664}");
                public static readonly ID FacetsToDisplay = new ID("{2D7892C2-720D-48E9-A354-E7264067F771}");
                public static readonly ID MediaPageType = new ID("{AAAA7504-03B4-48DE-B9F4-3949C48831F8}");

            }
        }

        public static class FacetFolder
        {
            public static readonly ID ID = new ID("{06C04293-2010-40C3-8A09-7425B13A0649}");

            public static class Fields
            {
                public static readonly ID Key = new ID("{937AAC9F-F672-4DC2-A164-F235A15E6A60}");
            }
        }

        public static class FacetItem
        {
            public static readonly ID ID = new ID("{97BA1597-E4A4-402A-899E-DE0A96D50E1F}");

            public static class Fields
            {
                public static readonly ID Text = new ID("{BB5532C5-2397-46FB-BBBF-82B1AB644F55}");
                public static readonly ID Value = new ID("{7DD25DF0-E40A-4A4D-A44A-3A486FC43A39}");
            }
        }

        public static class PageTypeFolder
        {
            public static readonly ID ID = new ID("{854F20A6-3E8C-4160-8333-B28D7D2928C6}");
        }

        public static class PageType
        {
            public static readonly ID ID = new ID("{7D5B8CBA-CE40-4E5B-8967-646A1AF0F0BA}");

            public static class Fields
            {
                public static readonly ID PrimaryCategory = new ID("{29FF3BE2-31A8-43BB-BC02-1AD9B13251E1}");
                public static readonly ID SecondaryCategory = new ID("{508B9FDA-2065-49EE-A368-C9CC1B72BFC7}");
            }
        }

        public static class DocumentTypesRoot
        {
            public static readonly ID ID = new ID("{24923ECE-BFBF-4A6C-9F6D-37D6118703A6}");
        }

        public static class IndexableDocument
        {
            public static readonly ID ID = new ID("{C7521CB9-E8D9-4968-A528-626070DDD734}");

            public static class Fields
            {
                public static readonly ID Text = new ID("{BB5532C5-2397-46FB-BBBF-82B1AB644F55}");
                public static readonly ID Value = new ID("{7DD25DF0-E40A-4A4D-A44A-3A486FC43A39}");
            }
        }

        public static class SearchFacetsRoot
        {
            public static readonly ID ID = new ID("{0090B79E-3401-4A2A-8AA6-16DAD6869091}");
        }

        public static class SiteSettings
        {
            public static readonly ID ID = new ID("{88CC0ABD-B528-4236-8345-937E24A265EE}");

            public static class Keys
            {
                public static string NotFoundItemPropertyKey = "marcusNotFoundItem";
            }

            public static class Fields
            {
                public static readonly ID SiteName = new ID("{5CBF2679-97D0-4971-8594-05C8B3CFE4D9}");
                public static readonly ID DefaultImage = new ID("{DB706FCF-4253-41D4-AD74-32D98C970B92}");
                public static readonly ID HomePage = new ID("{90DC9A80-4373-4816-9FC0-8A65731F436D}");
                public static readonly ID PageNotFound = new ID("{6040D70E-A2A1-416D-B485-16E3694963D9}");
                public static readonly ID SearchResultsPage = new ID("{73FE6D74-0B1F-46B5-9E57-5D02F2241479}");
                public static readonly ID SearchRoot = new ID("{29F30243-107B-46A9-A902-B0089FC6B203}");
                public static readonly ID MediaSearchRoot = new ID("{FAF4A2CF-E4C6-42DB-9163-2764E2845E2C}");
                public static readonly ID DonatePage = new ID("{0F4DD4D9-8482-4034-A7D9-4BE287BCCD8F}");
            }
        }

        public static class NavigationSettings
        {
            public static class Fields
            {
                public static readonly ID SearchTitle = new ID("{827fc787-2cf7-498a-8649-b3be5eed4a98}");
                public static readonly ID SearchIcon = new ID("{7e6999e7-4e86-418d-8ae0-616e8f2ba9bf}");
                public static readonly ID PrimaryLinks = new ID("{7E23B912-9179-438A-841F-408B5355A765}");
                public static readonly ID DesktopLogo = new ID("{5932fc3d-9262-4da5-baee-c307456330cd}");
                public static readonly ID MobileLogo = new ID("{3994b899-e813-47f8-9877-5f926ab488c4}");
                public static readonly ID NavigationLinks = new ID("{32888EA1-BFC8-40C1-BA83-55B31A797023}");
                public static readonly ID DonateShowInFooter = new ID("{E86B991A-C689-4956-A1A0-1B9E0F1C7131}");
                public static readonly ID DonateShowInHeader = new ID("{43811F56-C3E6-480B-AC9E-2014DDAC2B3F}");
            }
        }

        public static class FooterSettings
        {
            public static class Fields
            {
                public static readonly ID ContactTitle = new ID("{B9846B57-02CB-4979-AF5F-2158989849F9}");
                public static readonly ID ContactPhone = new ID("{5636E7F4-3F77-4F76-8423-C28CD4A5DC6F}");
                public static readonly ID ContactAddress = new ID("{30CEBC8C-4BE5-46E1-B15C-98949A29D601}");
                public static readonly ID HoursOfOperation = new ID("{E6A2FA76-DD78-481A-B63B-DF9E5506202B}");
                public static readonly ID Copyright = new ID("{BAEE7DF5-ECAB-441F-8A80-7F5ECB5BDD4F}");
                public static readonly ID FooterLogo = new ID("{66CD6D0A-4181-4206-AA73-3CCC739C453F}");
                public static readonly ID ShareUrls = new ID("{640E4AD1-9927-4E41-AF01-E8DBFDA294AF}");
                public static readonly ID SubsidiaryNotice = new ID("{F35AA421-39A7-44D8-B304-3EB199FC6B7C}");
            }
        }

        public static class SocialShareSettings
        {
            public static class Fields
            {
                public static readonly ID ShareUrl = new ID("{14390356-C48D-47BE-83C8-4F1DFC7C44A8}");
                public static readonly ID ShareClass = new ID("{0A767840-08D3-41A3-B984-22DE024D5EB6}");
            }
        }

        public static class UtilityLink
        {
            public static readonly ID ID = new ID("{91C65699-5877-4FD9-8767-FE990EC97609}");

            public static class Fields
            {
                public static readonly ID Title = new ID("{B85A0E69-E864-4118-8D5A-CFEF4A865939}");
                public static readonly ID LinkUrl = new ID("{F0DA3FB3-1CB8-4BE0-8499-6F8BFEA16E30}");
            }
        }

        public static class MarketoSettings
        {
            public static readonly ID ID = new ID("{A22F1D9E-0D2F-4040-8E2A-B9813ED4448A}");

            public static class Fields
            {
                public static readonly ID ScriptSource = new ID("{BEA74682-F70E-4D52-9F72-4F71635C8D6B}");
                public static readonly ID FormId = new ID("{C7B67234-FCF6-45E2-B838-AA89A3DCC77F}");
                public static readonly ID FormScript = new ID("{DF12826C-FD53-476A-9318-E4E3518DDDBB}");
            }
        }

        public static class AnalyticsSettings
        {
            public static readonly ID ID = new ID("{2273475C-ADD9-4951-B50E-BCA27000002C}");

            public static class Fields
            {
                public static readonly ID LaunchPixel = new ID("{4A79DC10-D64B-4BD1-84A9-DA3FFC41C115}");
            }
        }
    }
}