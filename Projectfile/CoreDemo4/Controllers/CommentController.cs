using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult PartialAddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
            comment.CommentStatus = true;
            comment.BlogID = 2008;
            cm.TAdd(comment);
            return RedirectToAction("Index", "Blog");
        }

        [HttpPost]
        public IActionResult CommentListByBlog(int id)
        {
            var value = cm.GetList(id);
            return RedirectToAction("Index", "Blog");
        }
    }
}
