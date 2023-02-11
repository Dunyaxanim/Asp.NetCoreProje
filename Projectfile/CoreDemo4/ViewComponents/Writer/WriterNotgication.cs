using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.ViewComponents.Writer
{
    public class WriterNotgication : ViewComponent
    {
       NotificationManager nm = new NotificationManager(new EfNotificationRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.ShowNotification = nm.GetList();
            var value = nm.GetList();
            return View(value);
        }
    }
}
