using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chick.ModelsViews.Kalendarz
{
    public class DaniaWPosilkuPartial
    {
        public int? ID { get; set; }

        public DateTime? Godzina { get; set; }

        public string NazwaDania { get; set; }

        public int? Kalorycznosc { get; set; }

        public double? Bialka { get; set; }

        public double? Tluszcze { get; set; }

        public double? Weglowodany { get; set; }

        public int? Waga { get; set; }

        public string KluczDania { get; set; }

        public string KluczDiety { get; set; }

        public string KluczDnia { get; set; }

        public int Posilek { get; set; }

        public DateTime? Data { get; set; }
    }
}