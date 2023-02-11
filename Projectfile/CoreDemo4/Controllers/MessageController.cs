using BusinessLayer.Concreate;
using CoreDemo4.Helpers;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
       
        Message2Manager message2 = new Message2Manager(new EfMessage2Repository());
      
        public IActionResult InBox()
        {
            //int id = 5;
            //var value = message2.GetListWithMessaageByWriter(id);
            return View(/*value*/);
        }

        public IActionResult MessageDetail(int id)
        {
            
            var value = message2.TGetById(id);
            return View(value);
        }

       
        #region Send
        public IActionResult Send()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Send(Message2 message, IFormFile Attachment)
        {
            string mgs = "Email göndərilmədi.";
            try
            {
                await Helper.SendMessage(message.Subject, message.Body, message.To, Attachment);
                mgs = "Email göndərildi.";
            }
            catch (Exception e)
            {
                mgs = e.Message;
            }
            ViewBag.Mgs = mgs;
            return View();
        }
        #endregion
    }
}
