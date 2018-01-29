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
    }

    public class SearchResultItem : ISearchResultItem
    {
        public string Name { get; set; }
        public string PreviewText { get; set; }
        public string Url { get; set; }
        public DateTime StartPublish { get; set; }

        public string[] Languages { get; set; }
        public string CurrentLanguage { get; set; }

        public ContentReference ContentRef { get; set; }


    }

}
