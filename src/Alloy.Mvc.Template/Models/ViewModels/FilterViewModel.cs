using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlloyTemplates.Models.ViewModels.Filters;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Routing;

namespace AlloyTemplates.Models.ViewModels
{
    public class FilterViewModel
    {
        public FilterViewModel(ContentReference currentPage, string updateTargetId)
        {
            UpdateTargetId = updateTargetId;
            PageUrl = UrlResolver.Current.GetUrl(currentPage);
        }

        public Url PageUrl { get; set; }
        public string UpdateTargetId { get; set; }
        public FilterMenu PageTypeList { get; set; }
    }
}
