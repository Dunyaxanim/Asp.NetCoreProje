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
    public class NewsLatterController : Controller
    {
        NewsLatterManager nm = new NewsLatterManager(new EfNewsLatterRepository());
        [HttpGet]
        public IActionResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter news)
        {
            news.MailStatus = true;
            nm.AddNewsLatter(news);
            return RedirectToAction("Index","Blog");
        }
    }
}
