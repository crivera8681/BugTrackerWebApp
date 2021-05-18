using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTrackerWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Bug Tracker Application";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Carlos Rivera";

            return View();
        }
    }
}