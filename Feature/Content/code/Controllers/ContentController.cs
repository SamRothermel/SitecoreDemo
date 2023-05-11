using Glass.Mapper.Sc.Web.Mvc;
using SitecoreDemo.Feature.Content.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreDemo.Feature.Content.Controllers
{
    public class ContentController : Controller
    {
        private readonly IMvcContext _mvcContext;
        public ContentController(IMvcContext mvcContext)
        {
            _mvcContext = mvcContext;
        }

        public ActionResult StandardSection()
        {
            var datasource = _mvcContext.GetRenderingParameters<StandardSection>();
            return View("~/Views/Content/StandardSection.cshtml", datasource);
        }

        public ActionResult EditableSection()
        {
            var datasource = _mvcContext.GetRenderingParameters<EditableSection>();
            return View("~/Views/Content/EditableSection.cshtml", datasource);
        }

        public ActionResult HtmlContent()
        {
            var datasource = _mvcContext.GetRenderingParameters<HtmlContent>();
            return View("~/Views/Content/HtmlContent.cshtml", datasource);
        }
    }
}