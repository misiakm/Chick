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
                DataKoncowa = dataPoczatkowa.AddDays(iloscTygodni * 7).AddDays(-1)
            };
            db.Entry(dieta).State = EntityState.Added;
            db.SaveChanges();
            DodajTygodnie(kalorycznosc, dieta);
            
        }

        private void DodajTygodnie(int kalorycznosc, Dieta dieta)
        {
            Kalendarz k = new Kalendarz();
            int i = 0;
            for (DateTime data = k.PobierzPierwszyDzienTygodnia(dieta.DataPoczatkowa); data <= dieta.DataKoncowa; data = data.AddDays(7))
            {
                Tydzien tydzien = new Tydzien()
                {
                    Kalorycznosc = kalorycznosc,
                    Dieta = dieta.ID
                };
                db.Tygodnie.Add(tydzien);
                db.SaveChanges();
                DateTime dataDoPrzekazaniaPoczatkowa = dieta.DataPoczatkowa > data ? dieta.DataPoczatkowa : data;
                DateTime dataDoPrzekazaniaKoncowa = dieta.DataKoncowa > k.PobierzOstatniDzienTygodnia(dataDoPrzekazaniaPoczatkowa) ? k.PobierzOstatniDzienTygodnia(dataDoPrzekazaniaPoczatkowa) : dieta.DataKoncowa;
                DodajDni(dataDoPrzekazaniaPoczatkowa, ++i, tydzien, dataDoPrzekazaniaKoncowa);
            }
        }

        private void DodajDni(DateTime dataPoczatkowa, int i, Tydzien tydzien, DateTime dataKoncowa)
        {
            for (DateTime data = dataPoczatkowa; data <= dataKoncowa; data = data.AddDays(1))
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