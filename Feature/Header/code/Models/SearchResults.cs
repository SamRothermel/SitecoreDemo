using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDemo.Feature.Header.Models
{
    public class SearchResults
    {
        public string SearchTerm { get; set; }
        public List<PageItemSearchResult> PageList { get; set; }
    }
}