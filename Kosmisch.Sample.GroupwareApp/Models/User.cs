using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kosmisch.Sample.GroupwareApp.Models
{
    public class User
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MailAddress { get; set; }
    }
}