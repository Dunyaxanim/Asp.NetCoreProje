using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public string Sender { get; set; }
        public string Reciver { get; set; }
        public string Subject { get; set; }
        public int MessageDetails { get; set; }
        public DateTime MessageDate { get; set; }
        public bool Messagestatus { get; set; }
    }
}
