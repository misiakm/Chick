using Chick.Logika;
using Chick.Models;
using Chick.ModelsViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chick.Controllers
{
    public class LoginController : Controller
    {
        ChickDbContext db = new ChickDbContext();
        
        public ActionResult Index()
        {
            LoginPage uzytkownik = new LoginPage();
            return View(uzytkownik);

        }


        [HttpPost]
        public ActionResult Index(LoginPage login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            UzytkownikAkcje uzytkownikAkcje = new UzytkownikAkcje();
            Uzytkownik uzytkownik = uzytkownikAkcje.PobierzLogowanegoUzytkownika(login.Email, login.Password);
            if (uzytkownik == null)
            {
                ViewBag.Err = "Dane logowania są niepoprawne";
                login.Password = null;
                return View(login);
            }
            else
            {
                uzytkownikAkcje.UstawSesjeICookie(uzytkownik.ID);
                return RedirectToAction("Panel", "Home");
            }
        }

    }
}