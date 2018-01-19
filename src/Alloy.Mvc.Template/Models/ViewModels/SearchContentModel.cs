using System.Collections.Generic;
using AlloyTemplates.Models.Pages;
using EPiServer.Find.UnifiedSearch;

namespace AlloyTemplates.Models.ViewModels
{
    public class SearchContentModel : PageViewModel<SearchPage>
    {
        public SearchContentModel(SearchPage currentPage, string query) : base(currentPage)
        {
            Query = query;
        }

        public string Query { get; private set; }
        public UnifiedSearchResults Results { get; set; }

    }
}
