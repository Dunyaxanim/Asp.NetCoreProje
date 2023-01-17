using BusinessLayer.Concreate;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.ViewComponents.Writer
{
    public class WriterBlogOnDashboard : ViewComponent
    {
        WriteManager writerManager = new WriteManager(new EfWriterRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            ViewBag.M = usermail;
            var writerID = c.Writers.Where(x => x.WriterMail ==
            usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = writerManager.GetWriterById(writerID);

            return View(values);
        }
    }
}
 