using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NathanWebsiteV2.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }

        public Message()
        {

        }
        public Message(int messageID, string name, string email, string message)
        {
            this.MessageID = messageID;
            this.FullName = name;
            this.Email = email;
            this.Body = message;

        }
    }
}