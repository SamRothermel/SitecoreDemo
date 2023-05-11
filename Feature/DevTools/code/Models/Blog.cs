using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SitecoreDemo.Feature.DevTools.Models
{
    [XmlType(TypeName="url")]
    public class Blog
    {
        [XmlAttribute("loc")]
        public string Loc { get; set; }
        [XmlAttribute("lastmod")]
        public string LastMod { get; set; }
        [XmlElement("image", IsNullable =true)]
        public List<Image> Image { get; set; }

        public Blog()
        {
            Image = new List<Image>();
        }
    }

    [XmlType(TypeName="image")]
    public class Image
    {
        [XmlAttribute("loc")]
        public string ImgLoc { get; set; }
        [XmlAttribute("caption")]
        public string ImageCaption { get; set; }
    }
}