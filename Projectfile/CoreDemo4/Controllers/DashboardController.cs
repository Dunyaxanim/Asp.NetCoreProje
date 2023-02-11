using BusinessLayer.Concreate;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo4.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        private readonly UserManager<AppUser> _userManager;
        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        AppUser user = new AppUser();
       
        public IActionResult Index(int id)
        {
           
            ViewBag.CountBlog = bm.TGetCount();
            //ViewBag.CountBlogbyWriter = bm.GetBlogCountByWriterID(5);
            ViewBag.CountCategory = cm.TGetCount();
            TempData["UserId"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            

            var values = bm.GetList();
            return View(values);
        }
    }
}
