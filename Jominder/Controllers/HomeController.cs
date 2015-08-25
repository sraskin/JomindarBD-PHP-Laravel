using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jominder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult DeveloperHome()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Packages()
        {
            ViewBag.Message = "Your Packages page.";

            return View();
        }

        public ActionResult PackegePlan()
        {
            ViewBag.Message = "Your Packages page.";

            return View();
        }
    }
}