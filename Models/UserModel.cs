using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MKJVHHI_MVC.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        public bool IsUserActive { get; set; } = true;

        public string Gender { get; set; }

        public List<SelectListItem> UserList { get; set; }
    }
}