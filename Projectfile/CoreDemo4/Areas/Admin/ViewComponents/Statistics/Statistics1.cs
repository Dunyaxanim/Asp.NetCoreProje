using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreDemo4.Areas.Admin.ViewComponents.Statistics
{
    public class Statistics1: ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        ContactManager cm = new ContactManager(new EfContactFrameWork());
        CommentManager com = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke()
        {
            var valuebm = bm.TGetCount();
            var valuecm = cm.TGetCount();
            var valuecom = com.TGetCount();
            ViewBag.Countbm = valuebm;
            ViewBag.Countcm = valuecm;
            ViewBag.Countcom = valuecom;
            string api = "be68a122dc94c5d140de2ea49ffffc21";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=baki&mode=xml&laang=tr&units=matric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            var dgree = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
           
            ViewBag.Weather = dgree;
            return View();
        }
    }
}
