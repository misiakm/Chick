using Chick.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Chick.Logika
{
    public class Diety
    {
        ChickDbContext db = new ChickDbContext();

        public void DodajDiete(int pacjent, DateTime dataPoczatkowa, int iloscTygodni, int kalorycznosc)
        {
            Dieta dieta = new Dieta
            {
                Pacjent = pacjent,
                DataPoczatkowa = dataPoczatkowa,
                IloscTygodni = iloscTygodni,
                DataKoncowa = dataPoczatkowa.AddDays(iloscTygodni * 7)
            };
            db.Entry(dieta).State = EntityState.Added;
            db.SaveChanges();
            DodajTygodnie(dataPoczatkowa, iloscTygodni, kalorycznosc, dieta);
            
        }

        private void DodajTygodnie(DateTime dataPoczatkowa, int iloscTygodni, int kalorycznosc, Dieta dieta)
        {
            for (int i = 1; i <= iloscTygodni; i++)
            {
                Tydzien tydzien = new Tydzien()
                {
                    Kalorycznosc = kalorycznosc,
                    Dieta = dieta.ID
                };
                db.Entry(tydzien).State = EntityState.Added;
                db.SaveChanges();
                DodajDni(dataPoczatkowa, i, tydzien);
            }
        }

        private void DodajDni(DateTime dataPoczatkowa, int i, Tydzien tydzien)
        {
            for (DateTime data = dataPoczatkowa.AddDays((i - 1) * 7); data < dataPoczatkowa.AddDays(i * 7); data = data.AddDays(1))
            {
                Dzien dzien = new Dzien()
                {
                    Tydzien = tydzien.ID,
                    Data = data
                };
                db.Entry(dzien).State = EntityState.Added;
            }
            db.SaveChanges();
        }
    }
}