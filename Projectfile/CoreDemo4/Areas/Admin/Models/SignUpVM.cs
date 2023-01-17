using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Areas.Admin.Models
{
    public class SignUpVM
    {
        [Display(Name = "Ad/Soyad")]
        [Required(ErrorMessage = "Ad/Soyad daxil edin")]
        public string NameSurname { get; set; }

        [Display(Name = "İstifadəçi adı")]
        [Required(ErrorMessage = "İstifadəçi adı daxil edin")]
        public string UserName { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Mail daxil edin")]
        public string Mail { get; set; }

        [Display(Name = "Şifrə")]
        [Required(ErrorMessage = "Şifrəni daxil edin")]
        public string Password { get; set; }

        [Display(Name = "Təkrar şifrə")]
        [Compare("Password", ErrorMessage ="Daxil olunan şifrələr eyni olmalıdır")]
        public string ConfirmPassword { get; set; }
    }
}
