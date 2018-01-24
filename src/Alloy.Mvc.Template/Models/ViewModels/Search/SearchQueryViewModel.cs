using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyTemplates.Models.ViewModels.Search
{
    public class SearchQueryViewModel
    {

        public string query { get; set; }
        public int fetchPageNumber { get; set; }
        public string lang { get; set; }
        public string pubDate { get; set; }

    }
}
