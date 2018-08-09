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
        static ChickDbContext db = new ChickDbContext();

        public ActionResult Klienci()
        {
            int? UzytkownikID = UzytkownikAkcje.PobierzIDUzytkownikaZCookie();
            var q = db.Pacjenci.Where(x => x.Dietetyk == UzytkownikID).Select(x => x.Nazwisko).ToList();
            return Json(q, JsonRequestBehavior.AllowGet);
        }


        public ActionResult LeweMenu()
        {
            
            return PartialView();
        }

        public ActionResult Naglowek(string Naglowek)
        {
            var q = UzytkownikAkcje.PobierzUzytkownikaZCookie();
            ViewBag.uzytkownik = $"{q.Imie} {q.Nazwisko}";
            return PartialView();
        }
    }
}