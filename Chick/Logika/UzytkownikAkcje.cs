using Chick.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Chick.Logika
{
    public class UzytkownikAkcje
    {
        ChickDbContext db = new ChickDbContext();

        /// <summary>
        /// Zwraca uzytkownika na podstawie maila i hasla. Jesli takiego nie ma, to zwraca null
        /// </summary>
        public Uzytkownik PobierzLogowanegoUzytkownika(string email, string haslo)
        {
            string zahaslowane = GetMd5Hash(haslo);
            Uzytkownik uzytkownik = db.Uzytkownicy.Where(x => x.Email == email && x.Haslo == zahaslowane).FirstOrDefault();
            return uzytkownik;
        }

        /// <summary>
        /// Ustawia sesje i cookie
        /// </summary>
        /// <param name="IDUzytkownika">ID uzytkownika</param>
        public void UstawSesjeICookie(int IDUzytkownika)
        {
            HttpCookie cookie = new HttpCookie("Uzytkownik");
            cookie["ID"] = IDUzytkownika.ToString();
            cookie.Expires = DateTime.Now.AddYears(10);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        /// <summary>
        /// Pobiera uzytkownika z Cookie
        /// </summary>
        /// <returns>Uzytkownik albo null</returns>
        public static Uzytkownik PobierzUzytkownikaZCookie()
        {
            ChickDbContext db = new ChickDbContext();
            var request = HttpContext.Current.Request;
            if (request.Cookies["Uzytkownik"] != null)
            {
                if (request.Cookies["Uzytkownik"]["ID"] != null)
                    return db.Uzytkownicy.Find(int.Parse(request.Cookies["Uzytkownik"]["ID"]));
            }
            return null;
        }


        public static int? PobierzIDUzytkownikaZCookie()
        {
            ChickDbContext db = new ChickDbContext();
            var request = HttpContext.Current.Request;
            if (request.Cookies["Uzytkownik"] != null)
            {
                if (request.Cookies["Uzytkownik"]["ID"] != null)
                    return int.Parse(request.Cookies["Uzytkownik"]["ID"]);
            }
            return null;
        }

        /// <summary>
        /// Szyfruje frazę do MD5
        /// </summary>
        /// <param name="input">Fraza, ktora ma zostac zaszyfrowana</param>
        /// <returns>Zaszyfrowana fraza</returns>
        public string GetMd5Hash(string input)
        {
            MD5 mD5 = MD5.Create();
            byte[] data = mD5.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}