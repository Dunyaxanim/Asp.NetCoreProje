using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Models
{
    public class LoginVM
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email daxil edin.")]
        public string Email { get; set; }

        [Display(Name = "Kod")]
        [Required(ErrorMessage = "Kod daxil edin ")]
        public string Password { get; set; }
    }
}
