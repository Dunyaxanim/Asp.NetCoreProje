using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Areas.Admin.ViewComponents.Statistics
{
    public class Statistics2:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        
        public IViewComponentResult Invoke()
        {
            var valuebm = bm.GetBlogByIDlast10Blog().OrderByDescending(x => x.BlogID).Select(x => x.BlogTitle).FirstOrDefault();
            ViewBag.Countbm = valuebm;
            return View();
        }
    }
}
