using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
   public  class AppUser:IdentityUser<int>
    {
        public string NamgeSurname { get; set; }
        public string ImgUrl { get; set; }

    }
}
