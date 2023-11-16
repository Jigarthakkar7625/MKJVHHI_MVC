using MKJVHHI_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MKJVHHI_MVC.Controllers
{
    public class UserController : Controller
    {

        // Localost://ControllerName/ActionName  


        // GET: User
        public ActionResult Index()
        {
            UserModel userModel = new UserModel();
            userModel.UserId = 10;
            userModel.UserName = "JIgar";

            return View(userModel);
        }
    }
}