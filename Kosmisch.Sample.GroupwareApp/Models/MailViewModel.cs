using Kosmisch.Sample.GroupwareApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Kosmisch.Sample.GroupwareApp.Models
{
    public class MailViewModel
    {
        public List<User> Users { get; set; }

        public IDictionary<string, bool> Ids { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }
    }
}