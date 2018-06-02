using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chick.ModelsViews
{
    public class JadlospisyPage
    {
        public int IDTygodnia { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public int Kalorycznosc { get; set; }

        public string Opis { get; set; }

        public string Klucz { get; set; }

        public DateTime? OstatniUlozonyDzien { get; set; }

        public DateTime DataKoncaDiety { get; set; }


    }
}