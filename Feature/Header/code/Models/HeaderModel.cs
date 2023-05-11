using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDemo.Feature.Header.Models
{
    [SitecoreType(TemplateId = Templates.HeaderItem.IdString, AutoMap = true)]
    public class HeaderModel
    {
        public virtual string Title { get; set; }
        public virtual string HeaderLinks { get; set; }
        public List<HeaderLink> LinkItems { get; set; }
    }
}