using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chick.ModelsViews.Kalendarz
{
    public class DatyDniTygodniaPartial
    {
        public DatyDniTygodniaPartial(DateTime data)
        {
            Data = data;
        }

        public DatyDniTygodniaPartial() { }

        public DateTime Data { get; set; }
    }
}