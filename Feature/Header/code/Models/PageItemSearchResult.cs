using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.ContentSearch.SearchTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDemo.Feature.Header.Models
{
    
    [SitecoreType(TemplateId = "{35223FDC-EDB6-4D56-BF7B-B5E7D71C1ECF}", AutoMap = true)]
    public class PageItemSearchResult
    {
        public virtual string MetaTitle { get; set; }
        public virtual string MetaDescription { get; set; }

        public string PageLinkUrl { get; set; }
    }
}