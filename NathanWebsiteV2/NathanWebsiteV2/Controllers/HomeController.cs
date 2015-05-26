using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NathanWebsiteV2.Models;

namespace NathanWebsiteV2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

         [HttpGet]
        public ActionResult Contact()
        {
            return PartialView(new Message());
        }
        [HttpPost]
        public ActionResult Contact(Message message)
        {
            try
            {
                if (ContactRepository.InsertMessage(message.FullName, message.Email, message.Body))
                {
                    ViewBag.Message = "Thank  you for e-mailing me! I'll get back with you as soon as possible!";
                    return View("ThankYou", message);
                }
                else
                {
                    ViewBag.Error = "Failed to update. Check code.";
                    return View("Contact");
                }
            }
            catch (Exception)
            {

                ViewBag.Error = "No file was uploaded";
                return View(new Message());
            }
        }

        public ActionResult ThankYou(Message message)
        {
            return PartialView(message);
        }
    }
}
  