using Glass.Mapper.Sc.Web.Mvc;
using SitecoreDemo.Feature.DevTools.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace SitecoreDemo.Feature.DevTools.Controllers
{
    public class DevToolsController : Controller
    {
        private readonly IMvcContext _mvcContext;
        public DevToolsController(IMvcContext mvcContext)
        {
            _mvcContext = mvcContext;
        }

        public ActionResult BlogImport()
        {
            return View("~/Views/DevTools/BlogImport.cshtml", null);
        }

        public ActionResult ProcessImport(HttpPostedFileBase file)
        {
            var blogs = new List<Blog>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Blog>));
            TextWriter writer = new StreamWriter(file.InputStream);
            serializer.Serialize(writer, blogs);

            foreach(var blogItem in blogs)
            {
                using(WebClient client = new WebClient())
                {
                    string content = client.DownloadString(blogItem.Loc);
                    int i = 0;
                }
            }

            return View();
        }
    }
}