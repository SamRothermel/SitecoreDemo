using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace SitecoreDemo.Feature.Content.Models
{
    [SitecoreType(TemplateId = Templates.EditableSectionItem.IdString, AutoMap = true)]
    public class StandardSection
    {
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual Image Image { get; set; }
        public virtual string Style { get; set; }
    }
}