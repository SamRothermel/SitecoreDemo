using Glass.Mapper.Sc.Web.Mvc;
using SitecoreDemo.Feature.Header.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SitecoreDemo.Feature.Header.Controllers
{
    public class HeaderController : Controller
    {
        private readonly IMvcContext _mvcContext;
        public HeaderController(IMvcContext mvcContext)
        {
            _mvcContext = mvcContext;
        }

        public ActionResult Header()
        {
            var datasource = _mvcContext.GetRenderingParameters<HeaderModel>();
            datasource.LinkItems = new List<HeaderLink>();
            foreach(string linkId in datasource.HeaderLinks.Split('|'))
            {
                if (string.IsNullOrEmpty(linkId))
                    continue;
                var item = Sitecore.Context.Database.GetItem(new Sitecore.Data.ID(linkId));
                if(item.TemplateID == Templates.HeaderLinkItem.Id)
                {
                    var linkItem = _mvcContext.SitecoreService.GetItem<HeaderLink>(new Guid(linkId));
                    datasource.LinkItems.Add(linkItem);
                }
            }
            return View("~/Views/Header/Header.cshtml", datasource);
        }
    }
}