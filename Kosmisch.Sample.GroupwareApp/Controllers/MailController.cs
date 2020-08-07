using System;
using System.Linq;
using System.Web.Mvc;
using Kosmisch.Sample.GroupwareApp.Data;
using Kosmisch.Sample.GroupwareApp.Models;

namespace Kosmisch.Sample.GroupwareApp.Controllers
{
    public class MailController : Controller
    {
        private UserContext db = new UserContext();

        // GET: Mail
        [Authorize]
        public ActionResult Index()
        {
            var Model = new MailViewModel();
            Model.Users = db.Users.ToList();
            return View(Model);
        }

        // GET: Mail/Create
        [HttpGet]
        [Authorize]
        public ActionResult Create([Bind(Include = "Ids")] MailViewModel model, string x)
        {
            return View(model);
        }

        // POST: Mail/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "Ids,Subject,Body")] MailViewModel model)
        {
            if (String.IsNullOrEmpty(model.Subject) || String.IsNullOrEmpty(model.Body) || model.Ids.Count == 0)
            {
                return View(model);
            }

            foreach (var item in db.Users.ToList())
            {
                if (model.Ids.ContainsKey(item.ID.ToString()))
                {
                    EmailHelper.Send(item.MailAddress, model.Subject, model.Body);
                }
            }
            return View("Done");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
