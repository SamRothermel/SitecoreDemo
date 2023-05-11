using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDemo.Feature.Header.Models
{
    [SitecoreType(TemplateId = Templates.HeaderLinkItem.IdString, AutoMap = true)]
    public class HeaderLink
    {
        public virtual Link Link { get; set; }
    }
}