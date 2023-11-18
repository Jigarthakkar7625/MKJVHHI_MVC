using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MKJVHHI_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var userID = TempData["UserId"];

            TempData.Keep("UserId"); // Keep

            return View();
        }

        public ActionResult About()
        {
            var userID = TempData["UserId"];

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var userID = TempData["UserId"];

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}