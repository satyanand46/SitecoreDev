using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Diagnostics;
using System.Web.Mvc;
using SitecoreDev.Childrens.web.Areas.Childrens.Extensions;
using SitecoreDev.Childrens.web.Areas.Childrens.Helpers.TemplatesFields;
using SitecoreDev.Childrens.web.Areas.Childrens.Interfaces;
using SitecoreDev.Childrens.web.Areas.Childrens.Modules;
//using static SitecoreDev.Childrens.web.Areas.Childrens.Helpers.TemplatesFields.SiteFieldsMatcher;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Controllers
{
    public class MarcusSearchResultsController : Controller
    {
        private readonly ISearchResultsService _searchResultsService;
        private readonly SiteSettings _siteSettingsService;

        public MarcusSearchResultsController(ISearchResultsService searchResultsService, ISettingsService settingService)
        {
            if (searchResultsService == null)
            {
                throw new ArgumentNullException("searchResultsService");
            }

            if (settingService == null)
            {
                throw new ArgumentNullException("settingService");
            }

            _searchResultsService = searchResultsService;
            _siteSettingsService = settingService.GetSiteSettings();
        }

        public ActionResult Index(string q, string sn, string pn, string pt, string f, string month)
        {
            int pageNumber = 1;

            bool success = int.TryParse(pn, out pageNumber);
            if (success == false || pageNumber <= 0)
            {
                pageNumber = 1;
            }

            SearchResults results = GetSearchResults(q, pageNumber, sn, pt, f, month);
            return View("~/Areas/Marcus/Views/EnhancedSearchResults.cshtml", results);
        }

        public ActionResult SearchFacets(string q, string sn, int? pn, string pt, string f, string month)
        {
            int pageNumber = 1;
            if (pn != null && pn.Value > 0)
            {
                pageNumber = pn.Value;
            }

            SearchResults results = GetSearchResults(q, pageNumber, sn, pt, f, month);
            return View("~/Areas/Marcus/Views/EnhancedSearchFacets.cshtml", results);
        }

        private SearchResults GetSearchResults(string query, int page, string sortDirection, string pageType, string facets, string month)
        {
            SearchResults results = _searchResultsService.GetResults(new SearchQuery()
            {
                QueryText = query,
                CurrentPage = page,
                Sort = sortDirection,
                EventMonth = month,
                PageType = string.IsNullOrWhiteSpace(pageType) ? PageFieldsMatcher.BasePage.PageTypes.Resources : pageType,
                Facets = facets.ParseQueryStringFacets(),
            });
            return results;
        }
    }
}