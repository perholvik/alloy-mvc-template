using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace AlloyTemplates.Business.Search
{
    public class SearchResult
    {

        public List<SearchResultItem> Hits { get; set; }

        public SearchResult()
        {
            Hits = new List<SearchResultItem>();
        }
    }

    public class SearchResultItem : ISearchResultItem
    {
        public string Title { get; set; }
        public string PreviewText { get; set; }
        public string Url { get; set; }



    }

}
