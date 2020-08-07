using System.Collections.Generic;

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