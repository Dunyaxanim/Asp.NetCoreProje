using BusinessLayer.Concreate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        WriteManager Wb = new WriteManager(new EfWriterRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult Indesx()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        #region BlogReadAll
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }
        #endregion

        #region BlaogListByWriter
        public IActionResult BlaogListByWriter()
        {


            var usermail = User.Identity.Name;
            ViewBag.M = usermail;
            var writerID = c.Writers.Where(x => x.WriterMail ==
            usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = bm.GetListBlogCategoryByWriterId(writerID);
            return View(values);
        }
        #endregion

        #region AddBlog
        [HttpGet]
        public IActionResult AddBlog()
        {

            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            ViewBag.cv = categoryvalues;
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            var usermail = User.Identity.Name;
            ViewBag.M = usermail;
            var writerID = c.Writers.Where(x => x.WriterMail ==
            usermail).Select(y => y.WriterID).FirstOrDefault();
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            ViewBag.cv = categoryvalues;

            BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(blog);
            if (result.IsValid)
            {

                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
                blog.WriterID = writerID;
                bm.TAdd(blog);
                return RedirectToAction("Index", "Blog");
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

        #region DeletBlog

        public IActionResult DeletBlog(int id)
        {

            var blog = bm.TGetById(id);
            var BlogStatus = blog.BlogStatus;
            if (!BlogStatus)
            {
                bm.TDelet(blog);
            }
            else
            {
                return RedirectToAction("BlaogListByWriter");
            }

            return RedirectToAction("BlaogListByWriter");
        }

        #endregion

        #region EditBlog
        [HttpGet]
        public IActionResult EditBlog(int id)
        {

            var value = bm.TGetById(id);
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            ViewBag.cv = categoryvalues;
            return View(value);
        }

        [HttpPost]
        public IActionResult EditBlog(int id,Blog blog)
        {
            var usermail = User.Identity.Name;
            ViewBag.M = usermail;
            var writerID = c.Writers.Where(x => x.WriterMail ==
            usermail).Select(y => y.WriterID).FirstOrDefault();

            var value = bm.TGetById(id);
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryvalues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            ViewBag.cv = categoryvalues;
            BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(blog);
            if (result.IsValid)
            {

                blog.WriterID = writerID;
                bm.TUpdate(blog);
                return RedirectToAction("BlaogListByWriter");
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


        #region MyRegion

        #endregion
        #region MyRegion

        #endregion



    }
}
