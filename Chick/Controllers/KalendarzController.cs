using Chick.Logika;
using Chick.Models;
using Chick.Models.Widoki;
using Chick.ModelsViews.Kalendarz;
using Chick.ModelsViews.Kalendarz.WidokTygodnia;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chick.Controllers
{
    public class KalendarzController : Controller
    {
        ChickDbContext db = new ChickDbContext();
        Widoki w = new Widoki();

        public ActionResult DodajDanie()
        {
            var q = (from d in w.SumyDan
                     select new WyborDania
                     {
                         ID = d.ID,
                         Bialko = (double)(d.Bialko / d.Waga * 100),
                         Kalorycznosc = (double)((d.Kalorycznosc * 100) / d.Waga),
                         Klucz = d.Klucz,
                         NazwaDania = d.Nazwa,
                         Tluszcze = (double)(d.Tluszcz / d.Waga * 100),
                         Weglowodany = (double)(d.Weglowodany / d.Waga * 100)
                     }).Take(20).ToList();
            return PartialView(q);
        }


        public ActionResult SzczegolyDzien(DateTime data, string kluczDiety, string kluczDnia)
        {            
            Kalendarz k = new Kalendarz();
            List<DaniaWPosilkuPartial> daniaWPosilkuList = k.PobierzDaniaWPosilku(kluczDiety, data);
            int? UserID = UzytkownikAkcje.PobierzIDUzytkownikaZCookie();
            var q = (from daniaWPosilu in w.DaniaWPosilku
                     where daniaWPosilu.Data == data && daniaWPosilu.KluczDiety == kluczDiety && daniaWPosilu.KluczDnia == kluczDnia && daniaWPosilu.UserID == UserID
                     group daniaWPosilu by new { daniaWPosilu.Data, daniaWPosilu.NazwaPosilku, daniaWPosilu.Posilek, daniaWPosilu.KluczDnia, daniaWPosilu.KluczDiety } into g
                     orderby g.Key.Posilek
                     select new PosilkiDzienPartial()
                     {
                         NazwaPosilku = g.Key.NazwaPosilku,
                         DataStart = data,
                         DataStop = data,
                         ID = g.Key.Posilek,
                         Klucz = kluczDiety,
                         SumaBialko = (double)(g.Sum(x => x.Bialka) ?? 0),
                         SumaKalorycznosc = g.Sum(x => x.Kalorycznosc) ?? 0,
                         SumaTluszcz = (double)(g.Sum(x => x.Tluszcze) ?? 0),
                         SumaWeglowodany = (double)(g.Sum(x => x.Weglowodany) ??0)
                     }).ToList();
            return View(q);
        }

        public ActionResult WybraneDanie(string ID)
        {
            Func<decimal?, int?, double> Na100 = (makro, waga) => (100 * (double)makro) / waga ?? 100;
            Debug.Print("abc");
            WyborDania danie = w.SumyDan.Where(x => x.Klucz == ID).Select(d => new WyborDania
            {
                ID = d.ID,
                Bialko = Na100(d.Bialko, d.Waga),
                Kalorycznosc = Na100((decimal)d.Kalorycznosc,d.Waga),
                Klucz = d.Klucz,
                NazwaDania = d.Nazwa,
                Tluszcze = Na100(d.Tluszcz, d.Waga),
                Weglowodany = Na100(d.Weglowodany, d.Waga),
                Waga = 100
            }).FirstOrDefault();
            return PartialView(danie);
        }

        public JsonResult ListaDan(int strona, string k)
        {
            List<WyborDania> q = new List<WyborDania>();
            
            if (k != "")
            {
                q = WyborDania.GetAll().Where(x => x.NazwaDania.Contains(k)).ToList();
            }
            else
            {
                q = WyborDania.GetAll();
            }
            q = q.Skip((strona - 1) * 20).Take(20).ToList();
            return Json(q, JsonRequestBehavior.AllowGet);
        }
            
    }
}