using Chick.ModelsViews.Kalendarz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chick.Logika
{
    public class Kalendarz
    {
        public List<DatyDniTygodniaPartial> PobierzDatyDniTygodniaPartial(DateTime data)
        {
            DateTime pierwszyDzienTygodnia = PobierzPierwszyDzienTygodnia(data);
            DateTime ostatniDzienTygodnia = pierwszyDzienTygodnia.AddDays(6);
            List<DatyDniTygodniaPartial> daty = new List<DatyDniTygodniaPartial>();
            for (DateTime i = pierwszyDzienTygodnia; i <= ostatniDzienTygodnia; i = i.AddDays(1))
            {
                daty.Add(new DatyDniTygodniaPartial(i));
            }
            return daty;
        }


        public DateTime PobierzPierwszyDzienTygodnia(DateTime data)
        {
            int nrDnia = (int)data.DayOfWeek;
            return data.AddDays(-1 * nrDnia + 1);
        }
    }
}