using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyTemplates.Business.Search
{
    public interface ISearchResultItem
    {
        string Name { get; set; }
        string Url { get; set; }
    }
}
