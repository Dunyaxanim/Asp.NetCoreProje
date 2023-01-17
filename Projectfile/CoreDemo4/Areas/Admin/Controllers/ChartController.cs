using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ChartController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
