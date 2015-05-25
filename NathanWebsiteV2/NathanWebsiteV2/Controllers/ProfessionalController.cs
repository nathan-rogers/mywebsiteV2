using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NathanWebsiteV2.Controllers
{
    public class ProfessionalController : Controller
    {
        // GET: Professional
        public ActionResult Professional()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }
        public ActionResult ProfessionalPage1()
        {
            
                return PartialView();
           
        }
        public ActionResult ProfessionalPage2()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }
        public ActionResult ProfessionalPage3()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }
        public ActionResult ProfessionalNavigation()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return PartialView();
        }
    }
}