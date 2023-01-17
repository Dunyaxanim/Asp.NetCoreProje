using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Models
{
    public class SiginInVM
    {
        [Display(Name = "İstifadəçi adı")]
        [Required(ErrorMessage = "İstifadəçi adı daxil edin")]
        public string UserName { get; set; }

        [Display(Name = "Şifrə")]
        [Required(ErrorMessage = "Şifrəni daxil edin")]
        public string Password { get; set; }
    }
}
