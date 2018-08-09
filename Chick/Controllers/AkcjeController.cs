using Chick.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chick.Controllers
{
    public class AkcjeController : Controller
    {
        // GET: Akcje
        public ActionResult DodajDania()
        {
            ChickDbContext db = new ChickDbContext();
            List<Skladnik> skladniki = db.Skladniki.ToList();
            foreach (Skladnik s in skladniki)
            {
                Danie danie = new Danie
                {
                    Nazwa = s.NazwaSkladnika,
                    WagaPorcji = 100
                };
                db.Dania.Add(danie);
                db.SaveChanges();
                Receptura receptura = new Receptura
                {
                    Skladnik = s.ID,
                    Danie = danie.ID,
                    Waga = 100
                };
                db.Receptury.Add(receptura);
                db.SaveChanges();
            }

            return null;
        }
    }
}