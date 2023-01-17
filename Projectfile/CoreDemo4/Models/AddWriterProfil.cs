using EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo4.Models
{
    public class AddWriterProfil
    {
        [Key]
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public IFormFile WriterIFormFile { get; set; }
        public string WriterAbout { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }
    }
}
