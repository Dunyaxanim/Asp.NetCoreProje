using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Models
{
    public class ResetPasswordModel
    {
        [Required]
        public string? Token { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Passwords { get; set; }


        //[Compare("Password", ErrorMessage = "Təkrar kod daxil edin.")]
        //public string ConfirmPassword { get; set; }
    }
}
