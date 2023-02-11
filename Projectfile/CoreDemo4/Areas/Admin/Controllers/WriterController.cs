using CoreDemo4.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class WriterController : Controller
    {

        public IActionResult Index2()
        {
            return View();
        }
        #region WriterList
        public IActionResult WriterList()
        {
            var jsonWriter = JsonConvert.SerializeObject(writers);
            return Json(jsonWriter);
        }

        #endregion

        #region GetWriterByID
        public IActionResult GetWriterByID(int writerid)
        {
            var finderWriter = writers.FirstOrDefault(x => x.Id == writerid);
            var jsonWriter = JsonConvert.SerializeObject(finderWriter);
            return Json(jsonWriter);
        }
        #endregion

        #region AddWriter
        public IActionResult AddWriter(WriterClass w)
        {
            writers.Add(w);
            var jsonWriter = JsonConvert.SerializeObject(w);
            return Json(jsonWriter);
        }
        #endregion

        #region DeletWriter
        public IActionResult DeletWriter(int id)
        {
           var writer= writers.FirstOrDefault(x=>x.Id == id);
            writers.Remove(writer);
           return Json(writer);
        }

        #endregion

        #region UpdateWriter
        public IActionResult UpdateWriter(WriterClass w)
        {
            var writer = writers.FirstOrDefault(x => x.Id == w.Id);
            writer.Name = w.Name;
            var jsonWriter = JsonConvert.SerializeObject(w);
            return Json(jsonWriter);
        }

        #endregion

        #region writers

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id=1,
                Name="Aysel"
            },
             new WriterClass
            {
                Id=2,
                Name="Xanim"
            },
              new WriterClass
            {
                Id=3,
                Name="Aysu"
            }
        };
        #endregion

    }
}
