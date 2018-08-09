using System;
using System.Linq;
using Chick.Logika;
using Chick.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chick.Tests
{
    [TestClass]
    public class UnitTest1
    {
        UzytkownikAkcje ua = new UzytkownikAkcje();
        ChickDbContext db = new ChickDbContext();
        Widoki w = new Widoki();

        [TestMethod]
        public void Szyfrowanie()
        {
            string zahaslowane = ua.GetMd5Hash("abc");
            Assert.AreEqual(zahaslowane, "900150983cd24fb0d6963f7d28e17f72");
        }

        //[TestMethod]
        //public void PobierzUzytkownikaLogin()
        //{
        //    Uzytkownik u = db.Uzytkownicy.Find(1);
        //    Assert.AreEqual(u, ua.PobierzLogowanegoUzytkownika("misiakmariusz@interia.pl", "abc"));
        //}

        [TestMethod]
        public void DaniaWPosilku()
        {
            var x = db.Dania.ToList();
            var z = w.Jadlospisy.ToList();
            var q = w.DaniaWPosilku.ToList();

        }
    }
}
