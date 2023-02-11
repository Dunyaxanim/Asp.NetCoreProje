using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.ViewComponents.Blog
{
    public class BlogStatisticaOnDashboard:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.CountBlog = bm.TGetCount();
            //ViewBag.CountBlogbyWriter = bm.GetBlogCountByWriterID(5);
            ViewBag.CountCategory = cm.TGetCount();
            return View();
        }
    }
}
