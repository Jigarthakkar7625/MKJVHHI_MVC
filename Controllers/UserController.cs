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


        // State management : 

        //Session
        //Cookie

        // Viewbag
        // transfer the data between Controller to view
        // Dynamic : NO need to do Typecasting


        // ViewData
        //// transfer the data between Controller to view
        ///Typecasting 


        // tempData
        //// transfer the data between Controller to Controller

        // GET: User

        //GET
        //POST //
        // Patch //Partially update :: Full
        // Put // Full update 
        // Delete


        public ActionResult Index()
        {

            MyDemoDatabase123Entities myDemoDatabase123Entities = new MyDemoDatabase123Entities();


            var getList = myDemoDatabase123Entities.EmpAddresses.ToList();


            UserModel userModel = new UserModel();
            userModel.UserId = 10;
            userModel.UserName = "JIgar";


            List<UserModel> users = new List<UserModel>
            {
                new UserModel(){ UserId = 1,UserName="Jigar" },
                new UserModel(){ UserId = 2,UserName="Vivek" },
                new UserModel(){ UserId = 3,UserName="Meet" },
                new UserModel(){ UserId = 4,UserName="KIH" },
            };


            var UserList = new List<SelectListItem>();
            UserList.Add(new SelectListItem
            {
                Text = "Jigar",
                Value = "1"
            });
            UserList.Add(new SelectListItem
            {
                Text = "Vivek",
                Value = "2"
            });

            //userModel.UserList = UserList;
            ViewBag.Users = users;
            ViewData["Users"] = users;

            TempData["UserId"] = "10";



            return View(userModel);
        }

        [HttpPost] // Action verb
        public ActionResult IndexPost(UserModel userModel)
        {

            var a = ViewBag.Users;

            TempData["UserId"] = "10";


            // Save in DB
            return RedirectToAction("Index","Home");
        }
    }
}
