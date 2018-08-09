using Chick.Models;
using Chick.Models.Widoki;
using Chick.ModelsViews.Kalendarz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chick.Logika
{
    public class Kalendarz
    {
        ChickDbContext db = new ChickDbContext();

        public List<DatyDniTygodniaPartial> PobierzDatyDniTygodniaPartial(DateTime data)
        {
            DateTime pierwszyDzienTygodnia = PobierzPierwszyDzienTygodnia(data);
            DateTime ostatniDzienTygodnia = PobierzOstatniDzienTygodnia(data);
            List<DatyDniTygodniaPartial> daty = new List<DatyDniTygodniaPartial>();
            for (DateTime i = pierwszyDzienTygodnia; i <= ostatniDzienTygodnia; i = i.AddDays(1))
            {
                daty.Add(new DatyDniTygodniaPartial(i));
            }
            return daty;
        }

        public DateTime PobierzOstatniDzienTygodnia(DateTime data)
        {
            return PobierzPierwszyDzienTygodnia(data).AddDays(6);
        }

        public DateTime PobierzPierwszyDzienTygodnia(DateTime data)
        {
            int nrDnia = (int)data.DayOfWeek;
            nrDnia = nrDnia == 0 ? 7 : nrDnia;
            return data.AddDays(-1 * nrDnia + 1);
        }

        public List<DaniaWPosilkuPartial> PobierzDaniaWPosilku(int Posilek, string Klucz, DateTime data)
        {
            Widoki w = new Widoki();
            int? UserID = UzytkownikAkcje.PobierzIDUzytkownikaZCookie();
            return w.DaniaWPosilku
                                .Where(x => x.UserID == UserID && x.Posilek == Posilek && x.KluczDiety == Klucz && x.Data == data)
                                .Select(x => new DaniaWPosilkuPartial()
                                {
                                    Bialka = (double?)x.Bialka,
                                    Godzina = x.Godzina,
                                    ID = x.ID,
                                    Kalorycznosc = x.Kalorycznosc,
                                    KluczDania = x.KluczDania,
                                    KluczDiety = x.KluczDiety,
                                    NazwaDania = x.NazwaDania,
                                    Tluszcze = (double?)x.Tluszcze,
                                    Waga = x.Waga,
                                    Weglowodany = (double?)x.Weglowodany,
                                    KluczDnia = x.KluczDnia,
                                    Data = x.Data,
                                    Posilek = x.Posilek
                                }).ToList();
        }

        public List<DaniaWPosilkuPartial> PobierzDaniaWPosilku(string Klucz, DateTime data)
        {
            Widoki w = new Widoki();
            int? UserID = UzytkownikAkcje.PobierzIDUzytkownikaZCookie();
            return w.DaniaWPosilku
                                .Where(x => x.UserID == UserID &&  x.KluczDiety == Klucz && x.Data == data)
                                .Select(x => new DaniaWPosilkuPartial()
                                {
                                    Bialka = (double?)x.Bialka,
                                    Godzina = x.Godzina,
                                    ID = x.ID,
                                    Kalorycznosc = x.Kalorycznosc,
                                    KluczDania = x.KluczDania,
                                    KluczDiety = x.KluczDiety,
                                    NazwaDania = x.NazwaDania,
                                    Tluszcze = (double?)x.Tluszcze,
                                    Waga = x.Waga,
                                    Weglowodany = (double?)x.Weglowodany,
                                    KluczDnia = x.KluczDnia,
                                    Data = x.Data,
                                    Posilek = x.Posilek
                                }).ToList();
        }



        //public IList<DaniaWPosilkuPartial> DaniaWPosilku(string kluczDiety, int posilek, DateTime data)
        //{
        //    var q = (from diety in db.Diety
        //             join tygodnie in db.Tygodnie on diety.ID equals tygodnie.Dieta
        //             join Dni in db.Dni on tygodnie.ID equals Dni.Tydzien
        //             join planyDni in db.PlanyDni on Dni.ID equals planyDni.Dzien
        //             join daniaJadlospisu in db.DaniaJadlospisu on planyDni.DanieJadlospisu equals daniaJadlospisu.PlanyDni)
        //}
    }
}