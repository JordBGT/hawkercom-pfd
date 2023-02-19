using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PFD_Team3.Models
{
    public class Contact
    {

        [Display(Name = "UserID")]
        public int ContactID { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Please enter a name!")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Please enter a description (maximum 200 words)!")]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
