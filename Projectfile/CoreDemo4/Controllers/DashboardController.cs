using BusinessLayer.Concreate;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index(int id)
        {

            ViewBag.CountBlog = bm.TGetCount();
            ViewBag.CountBlogbyWriter = bm.GetBlogCountByWriterID(5);
            ViewBag.CountCategory = cm.TGetCount();

            var values = bm.GetList();
            return View(values);
        }
    }
}
