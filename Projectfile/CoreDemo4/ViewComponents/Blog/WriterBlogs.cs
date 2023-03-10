using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.ViewComponents.Blog
{
    public class WriterBlogs: ViewComponent
    {
        BlogManager cm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke(int id)
        {
            var value = cm.GetBlogByID(id);
            return View(value);
        }
    }
}
