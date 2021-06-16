using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.Linq.Utilities;
using SitecoreDev.Childrens.web.Areas.Childrens.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Controllers
{
    public class SearchController : Controller
    {
        // GET: Childrens/Search
        public ActionResult Index()
        {
            var myResults = new SearchResults
            {
                Results = new List<SearchResult>()
            };
            string searchItem = Request.QueryString["searchItem"] ?? string.Empty;
            var searchIndex = ContentSearchManager.GetIndex("sc10sxa_choa_web_index"); // Get the search index
            var searchPredicate = GetSearchPredicate(searchItem); // Build the search predicate

            using (var searchContext = searchIndex.CreateSearchContext()) // Get a context of the search index
            {
                var searchResults = searchContext.GetQueryable<SearchModel>().Where(searchPredicate); // Search the index for items which match the predicate

                // This will get all of the results, which is not recommended
                var fullResults = searchResults.GetResults();

                foreach (var hit in fullResults)
                {
                    myResults.Results.Add(new SearchResult
                    {
                        Description = hit.Document.Description,
                        Title = hit.Document.ItemName,
                        fName = hit.Document.fName,
                        fbody = hit.Document.fbody
                    });
                }
                //return ResultJson(myResults);
                return View("~/Areas/Childrens/Views/Search/Index.cshtml",myResults);
            }
        }

        public static Expression<Func<SearchModel, bool>> GetSearchPredicate(string searchTerm)
        {
            var predicate = PredicateBuilder.True<SearchModel>();
            // Search the whole phrase – CONTAINS
          
            predicate = predicate.Or(x => x.Description.Contains(searchTerm));
            predicate = predicate.Or(x => x.Title.Contains(searchTerm));
            predicate = predicate.Or(x => x.fName.Contains(searchTerm));
            predicate = predicate.Or(x => x.fbody.Contains(searchTerm));

            return predicate;
        }
    }
}