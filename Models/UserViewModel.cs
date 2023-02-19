using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace PFD_Team3.Models
{
    public class UserViewModel
    {
        //UserID
        [Display(Name = "UserID")]
        public int UserID { get; set; }

        //Username
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter a name!")]
        [Display(Name = "Name")]
        public string UserName { get; set; }

        //Email
        [Display(Name = "Email Address")]
        [EmailAddress]
        //[ValidateEmailExist] will do later
        [Required(ErrorMessage = "Please enter an email address!")]
        [StringLength(100)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter a password!")]
        [StringLength(50)]
        public string Password { get; set; }

        public string Photo { get; set; }

        public IFormFile fileToUpload { get; set; }
    }
}
