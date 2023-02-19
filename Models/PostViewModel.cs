using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace PFD_Team3.Models
{
    public class PostViewModel
    {
        [Display(Name = "PostID")]
        public int PostID { get; set; }

        [Display(Name = "UserID")]
        public int UserID { get; set; }

        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Please enter a title!")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Please enter a hawker name!")]
        [Display(Name = "HawkerName")]
        public string HawkerName { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Please enter a hawker store name!")]
        [Display(Name = "HawkerStore")]
        public string HawkerStore { get; set; }

        [Required(ErrorMessage = "Please enter a rating between 1-5!")]
        [Display(Name = "Rating")]
        [Range(1, 5)]
        public int Rating { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage = "Please enter a description (max 500 words)!")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [StringLength(255, ErrorMessage = "Your input has exceeded the 255 characters limit!")]
        [Display(Name = "FileSubmitted")]
        public string? FileSubmitted { get; set; }
        public IFormFile fileToUpload { get; set; }
    }
}
