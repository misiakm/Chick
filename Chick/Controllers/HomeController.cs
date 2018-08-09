using Chick.Logika;
using Chick.Models;
using Chick.Models.Widoki;
using Chick.ModelsViews;
using Chick.ModelsViews.Kalendarz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chick.Controllers
{
    public class HomeController : Controller
    {
        Widoki widoki = new Widoki();
        ChickDbContext db = new ChickDbContext();
        PanelController _panel = new PanelController();

        public ActionResult Panel(DateTime? data)
        {
            Uzytkownik uzytkownik = UzytkownikAkcje.PobierzUzytkownikaZCookie();
            if (uzytkownik == null) {
                return RedirectToAction("Index", "Login");
            }
            ViewBag.uzytkownik = $"{uzytkownik.Imie} {uzytkownik.Nazwisko}";
            ViewBag.WybranyDzien = data ?? DateTime.Now.Date;
            return View();
        }


        public ActionResult Kalendarz(DateTime? data)
        {
            ViewBag.WybranyDzien = data ?? DateTime.Now.Date;
            return PartialView();
        }


        public ActionResult Jadlospisy(DateTime? data)
        {
            data = data ?? DateTime.Now.Date;
            ViewBag.WybranyDzien = data;
            var q = (from j in widoki.Jadlospisy
                     where j.Data == data
                     select new JadlospisyPage
                     {
                         Imie = j.Imie,
                         Nazwisko = j.Nazwisko,
                         Kalorycznosc = j.Kalorycznosc,
                         DataKoncaDiety = j.DataKoncowa,
                         OstatniUlozonyDzien = j.OstatniUlozonyDzien,
                         Opis = j.Opis,
                         IDTygodnia = j.IDTygodnie,
                         Klucz = j.KluczDiety
                     }).ToList();
            return PartialView(q);
        }

        public ActionResult Tydzien(DateTime data, string klucz)
        {
            JadlospisyPage jadlospisy = widoki.Jadlospisy.Where(x => x.KluczDiety == klucz).Select(x => new JadlospisyPage() { Imie = x.Imie, Nazwisko = x.Nazwisko, Kalorycznosc = x.Kalorycznosc, Klucz = x.KluczDiety}).FirstOrDefault();
            ViewBag.Tytul = jadlospisy.Imie + " " + jadlospisy.Nazwisko + " (" + jadlospisy.Kalorycznosc + ")";
            ViewBag.WybranyDzien = data;
            return View();
        }

        public ActionResult DatyDniTygodnia(DateTime data)
        {
            Kalendarz k = new Kalendarz();
            var datyDniTygodnia = k.PobierzDatyDniTygodniaPartial(data);
            return PartialView(datyDniTygodnia);
        }

        public ActionResult Posilki(string klucz, DateTime data)
        {
            Kalendarz k = new Kalendarz();
            DateTime dataStart = k.PobierzPierwszyDzienTygodnia(data);
            DateTime dataStop = k.PobierzOstatniDzienTygodnia(data);
            var q = db.Posilki.Select(x => new PosilkiPartial() {
                        ID = x.ID,
                        NazwaPosilku = x.NazwaPosilku,
                        Klucz = klucz,
                        DataStart = dataStart,
                        DataStop = dataStop
                    }).ToList();
            return PartialView(q);
        }

        public ActionResult DaniaWPosilku(int Posilek, string Klucz, DateTime data)
        {
            Kalendarz k = new Kalendarz();
            List<DaniaWPosilkuPartial> q = k.PobierzDaniaWPosilku(Posilek, Klucz, data);        
            return PartialView(q);
        }

     

        public ActionResult NowyJadlospis(DateTime wybranaData)
        {
            Kalendarz kalendarz = new Kalendarz();
            NowyJadlospis nowyJadlospis = new NowyJadlospis()
            {
                DataPoczatkowa = kalendarz.PobierzPierwszyDzienTygodnia(DateTime.Now.AddDays(7)),
                ListaPacjentow = new List<SelectListItem>(),
                WybranaDataURL = wybranaData
            };
            int? dietetyk = UzytkownikAkcje.PobierzIDUzytkownikaZCookie();
            nowyJadlospis.ListaPacjentow = db.Pacjenci.Where(x => x.Dietetyk == dietetyk)
                .Select(x => new SelectListItem { Value = x.ID.ToString(), Text = x.Imie + " " + x.Nazwisko }).ToList();

            return PartialView(nowyJadlospis);
        }

        public ActionResult DodajJadlospis(NowyJadlospis nowyJadlospis)
        {
            if (ModelState.IsValid)
            {
                Diety diety = new Diety();
                diety.DodajDiete(nowyJadlospis.Pacjent, nowyJadlospis.DataPoczatkowa, nowyJadlospis.IloscTygodni, nowyJadlospis.Kalorycznosc);
            }
            
            return RedirectToAction("Panel",new {data = nowyJadlospis.WybranaDataURL });
        }

        
    }
}