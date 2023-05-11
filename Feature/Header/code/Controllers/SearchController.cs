using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.Linq.Utilities;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.Links;
using SitecoreDemo.Feature.Header.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SitecoreDemo.Feature.Header.Controllers
{
    public class SearchController : Controller
    {
        private readonly IMvcContext _mvcContext;
        public SearchController(IMvcContext mvcContext)
        {
            _mvcContext = mvcContext;
        }

        public ActionResult Search(string searchQuery = null)
        {
            if (searchQuery == null)
                return View("~/Views/Header/SearchResults.cshtml", null);

            var final = new SearchResults();
            final.SearchTerm = searchQuery;

            using (var context = ContentSearchManager.GetIndex("sitecore_web_index").CreateSearchContext())
            {
                var predicate = PredicateBuilder.True<SearchProviderResult>();

                predicate = predicate.And<SearchProviderResult>(x => x.TemplateId == new Sitecore.Data.ID(Templates.PageItem.IdString));
                predicate = predicate.And(x => x.Content.Contains(searchQuery));

                //var tagPredicate = tagValues.Aggregate

                var results = context.GetQueryable<SearchProviderResult>().Where(predicate).ToList();

                final.PageList = new List<PageItemSearchResult>();

                foreach(var result in results)
                {
                    if(result.TemplateId.ToString() == Templates.PageItem.IdString)
                    {
                        var searchResultItem = _mvcContext.SitecoreService.GetItem<PageItemSearchResult>(result.ItemId.ToGuid());
                        searchResultItem.PageLinkUrl = LinkManager.GetItemUrl(result.GetItem());
                        final.PageList.Add(searchResultItem);
                    }
                }
            }

            return View("~/Views/Header/SearchResults.cshtml", final);
        }
    }
}