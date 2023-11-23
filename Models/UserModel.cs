using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MKJVHHI_MVC.Models
{
    public class UserModel
    {

        public int UserId { get; set; }

        [DisplayName("User Name")]
        [Required(ErrorMessage = "This User Name is required! please filllllllllll")]
        [StringLength(15,MinimumLength = 10, ErrorMessage = "String length should be in between 10 to 15 character")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "pleas enter proper user name")]
        public string UserName { get; set; }

        [DisplayName("Email Address")]
        [Required(ErrorMessage = "Email is requierd")]
        [EmailAddress(ErrorMessage = "Please enter proper email validation")]
        public string Email { get; set; }



        [DisplayName("AGEE")]
        [Required(ErrorMessage = "Age is requierd")]
        [Range(18,35, ErrorMessage = "This is error message")]
        public string Age { get; set; }


        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is requierd")]
        public string Password { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "ConfirmPassword is requierd")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "ConfirmPassword is not matched !!!")]
        public string ConfirmPassword { get; set; }

        public bool IsUserActive { get; set; } = true;

        public string Gender { get; set; }

        public List<SelectListItem> UserList { get; set; }
    }
}