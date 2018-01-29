using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlloyTemplates.Models.ViewModels;
using EPiServer.Core;
using EPiServer.Search;
using EPiServer.Search.Queries;
using EPiServer.Search.Queries.Lucene;
using EPiServer.Security;
using EPiServer;
using EPiServer.Find;
using EPiServer.Find.Api;
using EPiServer.ServiceLocation;

namespace AlloyTemplates.Business.Search
{
    //public class SearchService : ISearchService
    public class SearchProvider : ISearchProvider
    {
        private readonly IClient _client;

        public SearchProvider(IClient epiFindClient)
        {
            _client = epiFindClient;
          }

        public SearchResult ExecuteSearch(SearchParameters searchParams)
        {
          
            var searchResults = _client.UnifiedSearchFor(searchParams.SearchString)
                .TermsFacetFor(x=> x.SearchSection)
                .FilterFacet("All", x => x.SearchSection.Exists())
                .Take(searchParams.HitsPrPage)
                .GetResult();

            //if (!string.IsNullOrEmpty(searchParams.pagetype))
            //{
            //    var searchResults = _client.UnifiedSearchFor(searchParams.SearchString)
            //        .TermsFacetFor(x => x.SearchHitTypeName)
            //        .FilterFacet("SearchHitTypeName", x => x.SearchHitTypeName == searchParams.pageType)
            //        .Take(searchParams.HitsPrPage)
            //        .GetResult();
            //}


            var result = new SearchResult();
            result.Hits = searchResults.Hits.Select(hit => new SearchResultItem()
            {
                Title = hit.Document.Title,
                Url = hit.Document.Url,
                PreviewText = hit.Document.Excerpt,
            }).ToList();

            result.Facets = searchResults.Facets;

            return result;
        }

    }
}
