using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chick.ModelsViews
{
    public class NowyJadlospis
    {
        public int Pacjent { get; set; }

        public List<SelectListItem> ListaPacjentow { get; set; }

        [DefaultValue(4)]
        public int IloscTygodni { get; set; }

        [DefaultValue(2000)]
        public int Kalorycznosc { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DataPoczatkowa { get; set; }

        public DateTime WybranaDataURL { get; set; }
    }
}