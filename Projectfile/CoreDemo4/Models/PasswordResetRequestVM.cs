using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Models
{
    public class PasswordResetRequestVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
