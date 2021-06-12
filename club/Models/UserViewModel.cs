using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace club.Models
{
    public class UserViewModel
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "This field is required")]
        [EmailAddress(ErrorMessage = "Input correct email")]
        [Remote(action: "CheckUnickEmail", controller: "MembersClub", ErrorMessage = "This email is already use")]
        public string Email { get; set; }
    }
}
