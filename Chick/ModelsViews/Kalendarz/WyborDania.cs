using Chick.Models.Widoki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Chick.ModelsViews.Kalendarz
{
    public class WyborDania
    {
        public int ID { get; set; }

        public string NazwaDania { get; set; }

        public double Kalorycznosc { get; set; }

        public double Bialko { get; set; }

        public double Weglowodany { get; set; }

        public double Tluszcze { get; set; }

        public string Klucz { get; set; }

        public int Waga { get; set; }

        public static List<WyborDania> GetAll()
        {
            Widoki w = new Widoki();
            return (from d in w.SumyDan
                    select new WyborDania
                    {
                        ID = d.ID,
                        Bialko = (double)(d.Bialko / d.Waga * 100),
                        Kalorycznosc = (double)((d.Kalorycznosc * 100) / d.Waga),
                        Klucz = d.Klucz,
                        NazwaDania = d.Nazwa,
                        Tluszcze = (double)(d.Tluszcz / d.Waga * 100),
                        Weglowodany = (double)(d.Weglowodany / d.Waga * 100)
                    }).ToList();
        }
    }
}