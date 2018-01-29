using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyTemplates.Business.Search
{
    public interface ISearchResult
    {
        int TotalHits { get; set; }
    }
}
