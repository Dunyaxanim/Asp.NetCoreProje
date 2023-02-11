using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        Message2Manager message2Manager = new Message2Manager(new EfMessage2Repository());

        public IViewComponentResult Invoke()
        {
            int id= 5;
            ViewBag.CountofMessage = message2Manager.TGetCount();
            var value = message2Manager.GetInboxListByWriter(id);
            return View(value);
        }
    }
}
