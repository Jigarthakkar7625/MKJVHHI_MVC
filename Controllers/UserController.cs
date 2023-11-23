using MKJVHHI_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MKJVHHI_MVC.Controllers
{
    public class UserController : Controller
    {


        MyDemoDatabase123Entities myDemoDatabase123Entities = new MyDemoDatabase123Entities();

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

            ModelState.AddModelError("Success", "MyError");
            ModelState.AddModelError("Error", "MyError");

            return View(userModel);
        }

        //.NET Framework : EF 

        // DF : EDMX
        // CF : Migraation
        // MF : 



        //.NET core Framework : EF Core
        // DF : RDMX Nathi avtu 
        // CF
        // MF



        [HttpPost] // Action verb
        public ActionResult Index(UserModel userModel)
        {

            if (ModelState.IsValid)
            {

                ModelState.AddModelError("Success", "MyError");

                ModelState.AddModelError("Success", "MyError");
            }

            var a = ViewBag.Users;

            TempData["UserId"] = "10";


            //Validaiton
            if (userModel.UserId == null)
            {
                ModelState.AddModelError("", "MyError");
            }



            // Save in DB
            return RedirectToAction("Index","Home");
        }

        
        public JsonResult GetJsonData(UserModel userModel) 
        {

            //var getList = myDemoDatabase123Entities.EmpAddresses.ToList();

            List<UserModel> users = new List<UserModel>
            {
                new UserModel(){ UserId = 1,UserName="Jigar" },
                new UserModel(){ UserId = 2,UserName="Vivek" },
                new UserModel(){ UserId = 3,UserName="Meet" },
                new UserModel(){ UserId = 4,UserName="KIH" },
            };




            return Json(users, JsonRequestBehavior.AllowGet);


        }
    }
}
