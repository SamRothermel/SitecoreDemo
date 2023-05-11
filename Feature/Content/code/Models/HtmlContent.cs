using Glass.Mapper.Sc.Configuration.Attributes;

namespace SitecoreDemo.Feature.Content.Models
{
    [SitecoreType(TemplateId = Templates.EditableSectionItem.IdString, AutoMap = true)]
    public class HtmlContent
    {
        public virtual string ContentSection { get; set; }
    }
}