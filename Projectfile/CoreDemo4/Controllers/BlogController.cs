using BusinessLayer.Concreate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
  using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo4.Controllers
{
    [Authorize(Roles = "User")]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        WriteManager Wb = new WriteManager(new EfWriterRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        CommentManager com = new CommentManager(new EfCommentRepository());
        AppUser appUser = new AppUser();
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        Context c = new Context();
        public BlogController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        
        #region BlogReadAll
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var values = bm.GetBlogByID(id).FirstOrDefault();
            var valuecount = com.GetList(id).ToList();
            ViewBag.count = valuecount.Count();
            return View(values);
        }
        #endregion

        #region BlaogListByUser
        public IActionResult BlaogListByWriter()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var blogs = bm.GetBlogListWithCategory().Where(x => x.AppUserId == userid).ToList();
            return View(blogs);
        }
        #endregion

        #region AddBlog
        [HttpGet]
        public IActionResult AddBlog()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
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

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

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
                blog.AppUserId = userId;
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
            var blogs = bm.GetBlogListWithCategory(id);
            ViewBag.category = cm.GetList().Where(x => x.CategoryStatus).ToList();
            return View(blogs);
        }
        [HttpPost]
        public IActionResult EditBlog(int id, Blog blog, int categoryid)
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var blogs = bm.GetBlogListWithCategory(id);

            ViewBag.category = cm.GetList().Where(x => x.CategoryStatus).ToList();

            BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(blog);
            if (result.IsValid)
            {
                blogs.AppUserId = userid;
                blogs.BlogContent = blog.BlogContent;
                blogs.BlogImage = blog.BlogImage;
                blogs.BlogTitle = blog.BlogTitle;
                blogs.BlogContent = blog.BlogContent;
                blogs.BlogTumbnailImage = blog.BlogTumbnailImage;
                blogs.CategoryID = categoryid;

                bm.TUpdate(blogs);
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

        #region CreateComment

      
        [HttpGet]
        public IActionResult Comment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Comment(Comment comment, int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var username = User.FindFirstValue(ClaimTypes.Name);
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
            comment.CommentStatus = true;
            comment.BlogID = id;
            comment.AppUserId = userId;
            comment.CommentUserName = username;
            com.CommentAdd(comment);
            return RedirectToAction("Index", "Blog");
        }
        #endregion

        #region CommentList
        public IActionResult CommentListByBlog(int id)
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var value = com.GetList(id).Where(x => x.AppUserId == userid);
            var username = User.FindFirstValue(ClaimTypes.Name);
            ViewBag.Comments = value;
            
            return RedirectToAction("BlogReadAll", "Blog");
        }
        #endregion

    }
}
