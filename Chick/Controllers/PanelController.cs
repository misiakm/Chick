using Chick.Logika;
using Chick.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chick.Controllers
{
    public class PanelController : Controller
    {
        ChickDbContext db = new ChickDbContext();

        public ActionResult Klienci()
        {
            int? UzytkownikID = UzytkownikAkcje.PobierzIDUzytkownikaZCookie();
            var q = db.Pacjenci.Where(x => x.Dietetyk == UzytkownikID).Select(x => x.Nazwisko).ToList();
            return Json(q, JsonRequestBehavior.AllowGet);
        }
    }
}