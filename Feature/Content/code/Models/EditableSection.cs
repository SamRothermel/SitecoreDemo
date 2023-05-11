using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDemo.Feature.Content.Models
{
    [SitecoreType(TemplateId = Templates.EditableSectionItem.IdString, AutoMap=true)]
    public class EditableSection : StandardSection
    {

    }
}