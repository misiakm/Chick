using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chick.ModelsViews.Kalendarz.WidokTygodnia
{
    public class PosilkiDzienPartial : PosilkiPartial
    {
        public double SumaBialko { get; set; }

        public double SumaTluszcz { get; set; }

        public double SumaWeglowodany { get; set; }

        public int SumaKalorycznosc { get; set; }

        public ICollection<DaniaWPosilkuPartial> DaniaWPosilku
        {
            get
            {
                Logika.Kalendarz kalendarz = new Logika.Kalendarz();
                return kalendarz.PobierzDaniaWPosilku(ID, Klucz, DataStart);
            }
        }
    }
}