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
    public class MessageController : Controller
    {

        Message2Manager message2 = new Message2Manager(new EfMessage2Repository());

        public IActionResult InBox()
        {
            int id = 5;
            var value = message2.GetListWithMessaageByWriter(id);
            return View(value);
        }

        public IActionResult MessageDetail(int id)
        {

            var value = message2.TGetById(id);
            return View(value);
        }


    }
}
