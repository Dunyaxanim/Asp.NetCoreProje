using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Message2
    {
        [Key]
        public int MessageID { get; set; }
        public int? SenderID { get; set; }
        public int? ReciverID { get; set; }
        public string Subject { get; set; }
        public string MessageDetails { get; set; }
        public DateTime MessageDate { get; set; }
        public bool Messagestatus { get; set; }
        public Writer SenderUser { get; set; }
        public Writer ReceiverUser { get; set; }


        [Required(ErrorMessage = "Mail ünvanı daxil edin.")]
        public string To { get; set; }
        public string Body { get; set; }



    }
}
