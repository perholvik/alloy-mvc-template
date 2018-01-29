using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer.Core;
using EPiServer.Framework.Web;
using EPiServer.Search;
using AlloyTemplates.Business;
using AlloyTemplates.Models.Pages;
using AlloyTemplates.Models.ViewModels;
using EPiServer.Find;
using EPiServer.Find.Framework;
using EPiServer.Web;
using EPiServer.Web.Hosting;
using EPiServer.Web.Mvc.Html;
using EPiServer.Web.Routing;

namespace AlloyTemplates.Controllers
{
    public class SearchPageController : PageControllerBase<SearchPage>
    {

        private const int MaxResults = 40;
        private readonly ISearchService _searchService;

        public SearchPageController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [ValidateInput(false)]
        public ViewResult Index(SearchPage currentPage, string query)
        {
            var model = new SearchContentModel(currentPage, query);
            if (string.IsNullOrEmpty(query))
            {
                return View(model);
            }

            var unifiedSearch = SearchClient.Instance.UnifiedSearchFor(query);
            model.Results = unifiedSearch.GetResult();
            return View(model);
        }


    }
}
