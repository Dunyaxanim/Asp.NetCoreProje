using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Controllers
{
    [AllowAnonymous]
    public class NotificationController : Controller
    {
        NotificationManager writeManager = new NotificationManager(new EfNotificationRepository());
        public IActionResult ShowAllNotification()
        {
            var value = writeManager.GetList();
            return View(value);
        }
        //public static string TimeDifference(DateTime startDate, DateTime endDate)
        //{
        //    //var differenceInterval = string.Empty;
        //    //if (endDate.Subtract(startDate).Hours > 0)
        //    //{
        //    //    var differenceHour = endDate.Subtract(startDate).Hours;
        //    //    differenceInterval = differenceHour + " Saat ";
        //    //}
        //    //if (endDate.Subtract(startDate).Minutes > 0)
        //    //{
        //    //    var differenceMinute = endDate.Subtract(startDate).Minutes;
        //    //    differenceInterval += differenceMinute + " Dakika ";
        //    //}
        //    //if (endDate.Subtract(startDate).Seconds > 0)
        //    //{
        //    //    var differenceSecond = endDate.Subtract(startDate).Seconds;
        //    //    differenceInterval += differenceSecond + " Saniye";
        //    //}

        //    //return differenceInterval;
        //    return startDate;
        //}
    }
}
