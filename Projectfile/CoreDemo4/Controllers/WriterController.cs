using BusinessLayer.Concreate;
using BusinessLayer.ValidationRules;
using CoreDemo4.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Controllers
{

    public class WriterController : Controller
    {

        WriteManager writeManager = new WriteManager(new EfWriterRepository());
        [Authorize]

        #region Index
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.M = usermail;
            Context c = new Context();
            var writerName = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.v2 = writerName;
            return View();
        }
        #endregion

        #region WriterProfil
        public IActionResult WriterProfil()
        {
            var value = writeManager.GetWriterById(5);
            return View(value);
        }
        #endregion

        #region WriterNavbarPartial
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        #endregion

        #region WriterFooterPartial
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        #endregion

        #region WriterEditProfil
        [AllowAnonymous]
        public IActionResult WriterEditProfil(int id)
        {
            Context c = new Context();
            var usermail = User.Identity.Name;
            ViewBag.M = usermail;
            var writerID = c.Writers.Where(x => x.WriterMail ==
            usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = writeManager.TGetById(writerID);

            return View(values);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult WriterEditProfil(Writer writer)
        {
            Context c = new Context();
            var usermail = User.Identity.Name;
            ViewBag.M = usermail;
            var writerID = c.Writers.Where(x => x.WriterMail ==
            usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = writeManager.TGetById(writerID);
            WriterValidator wv = new WriterValidator();
            ValidationResult result = wv.Validate(writer);
            if (result.IsValid)
            {
                writeManager.TUpdate(writer);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(values);
        }
        #endregion
       


        #region AddWriter
        [AllowAnonymous]
        public IActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult AddWriter(AddWriterProfil p)
        {

            Writer w = new Writer();

            //if (result.IsValid)
            //{ }
            if (p.WriterIFormFile != null)
            {
                var extestion = Path.GetExtension(p.WriterIFormFile.FileName);
                var newimagename = Guid.NewGuid() + extestion;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImagess/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterIFormFile.CopyTo(stream);
                w.WriterImage = newimagename;
            }
            w.WriterMail = p.WriterMail;
            w.WriterMail = p.WriterAbout;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            writeManager.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }
        #endregion
    }
}
