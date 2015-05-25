using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NathanWebsiteV2.Controllers
{
    public class TabContentController : Controller
    {
        // GET: TabContent
        public ActionResult Professional()
        {
            return View();
        }
        public ActionResult MyWork()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult ProfessionalNavigation()
        {
            return PartialView();
        }
    }
}