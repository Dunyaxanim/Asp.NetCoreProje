using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public string BlogTumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryID { get; set; }
        public int BlogScore { get; set; }
        public Category Category { get; set; }
        //public int WriterID { get; set; }
        //public Writer Writer { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
