using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Models
{
    public class UpdateUserVM
    {
        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Adınızı daxil edin.")]
        public string Name { get; set; }

        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Soy adınızı daxil edin.")]
        public string Surname { get; set; }

        [Display(Name = "Mail adresi")]
        [Required(ErrorMessage = "e-mail adı daxil edin.")]
        public string Mail { get; set; }

        [Display(Name = "İstifadəçi adı")]
        [Required(ErrorMessage = "İstifadəçi adı daxil edin.")]
        public string UserName { get; set; }

        [Display(Name = "İstifadəçi haqqında məlumat")]
        public string About { get; set; }

  
        [Display(Name = "Kod")]
        [Required(ErrorMessage = "Kod daxil edin ")]
        public string Password { get; set; }


        [Display(Name = "Təkrar kod")]
        [Compare("Password", ErrorMessage = "Təkrar kod daxil edin.")]
        public string ConfirmPassword { get; set; }
    }
}
