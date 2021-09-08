using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.Linq.Utilities;
using SitecoreDev.Strong4Life.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace SitecoreDev.Strong4Life.web.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult DoSearch()
        {
            var myResults = new SearchResults
            {
                Results = new List<SearchResult>()
            };
            string searchItem = Request.QueryString["searchItem"] ?? string.Empty;
            var searchIndex = ContentSearchManager.GetIndex("sc10sxa_s4l_index"); // Get the search index
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
                        Heading = hit.Document.Heading,
                        SubHeading = hit.Document.SubHeading,
                        abtName= hit.Document.abtName,
                         abtbody = hit.Document.abtbody
                    });
                }
                //return ResultJson(myResults);
                return View(myResults);
            }
        }

        public JsonResult ResultJson(object data)
        {
            return new JsonResult { JsonRequestBehavior = JsonRequestBehavior.AllowGet, Data = data };
        }

        public static Expression<Func<SearchModel, bool>> GetSearchPredicate(string searchTerm)
        {
            var predicate = PredicateBuilder.True<SearchModel>();
            // Search the whole phrase – CONTAINS
            predicate = predicate.Or(x => x.Heading.Contains(searchTerm)); 
            predicate = predicate.Or(x => x.SubHeading.Contains(searchTerm));
            predicate = predicate.Or(x => x.Description.Contains(searchTerm));
            predicate = predicate.Or(x => x.Title.Contains(searchTerm));
            predicate = predicate.Or(x => x.abtName.Contains(searchTerm));
            predicate = predicate.Or(x => x.abtbody.Contains(searchTerm));

            return predicate;
        }
    }
}