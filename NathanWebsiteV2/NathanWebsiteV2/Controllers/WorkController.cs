using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NathanWebsiteV2.Controllers
{
    public class WorkController : Controller
    {
        // GET: Work
        public ActionResult MyWork()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }
        public ActionResult Hackathon()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }
        public ActionResult Hackathon2()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }
        public ActionResult SpaceRace()
        {
            return PartialView();
        }
        public ActionResult Cybernetix()
        {
            return PartialView();
        }
        public ActionResult WorkNavigation()
        {
            return PartialView();
        }
    }
}