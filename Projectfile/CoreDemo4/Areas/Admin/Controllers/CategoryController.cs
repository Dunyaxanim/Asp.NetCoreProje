using BusinessLayer.Concreate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
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
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var value = cm.GetList();
            return View(value);
        }
        #region AddCategory
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCategory(Category c)
        {

            CategoryValidator cv = new CategoryValidator();
            ValidationResult result = cv.Validate(c);
            if (result.IsValid)
            {
                c.CategoryStatus = true;
                cm.TAdd(c);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        #endregion




        #region DeletCategory
        [HttpGet]
        public IActionResult DeletCategory(int id)
        {

            var category = cm.TGetById(id);
            var BlogStatus = category.CategoryStatus;
            if (BlogStatus)
            {
                cm.TDelet(category);
            }
            else
            {
                return RedirectToAction("Index", "Category");
            }

            return RedirectToAction("Index", "Category");
        }
        #endregion
        #region DeletBlog


        #endregion
    }
}
