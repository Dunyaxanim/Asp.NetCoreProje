using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Areas.Admin.ViewComponents.Statistics
{
    public class Statistics4 : ViewComponent
    {
        AdminManager cm = new AdminManager(new EfAdminRepository());

        public IViewComponentResult Invoke(int id)
        {
            id = 1;
            var valuebm = cm.GetByIdAdmin(id).Select(x => x.Name).FirstOrDefault();
            ViewBag.AdminName = valuebm;
            var valueimg = cm.GetByIdAdmin(id).Select(x => x.ImgUrl).FirstOrDefault();
            ViewBag.AdminImg = valueimg;
            var valuedescription = cm.GetByIdAdmin(id).Select(x => x.ShortDescription).FirstOrDefault();
            ViewBag.Admindescription = valuedescription;
            return View(); 
        }
    }
}
