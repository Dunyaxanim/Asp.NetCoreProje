using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.ViewComponents.Category
{
    public class CategoryListDashboard:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {

            var value = cm.GetList();
            return View(value);
        }
    }
}
