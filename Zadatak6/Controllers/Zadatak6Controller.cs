using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadatak6.Controllers
{/*Napravite ASP.NET Core MVC aplikaciju koja omogućuje korisniku unos dva cijela broja, te računa i ispisuje zbroj unesenih brojeva.

Za izradu pogleda (view), odnosno korisničkog sučelja upotrijebiti Bootstrap.*/
    public class Zadatak6Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Zbrajanje(string prvi, string drugi)
        {
            int.TryParse(prvi, out int Prvi);
            int.TryParse(drugi, out int Drugi);

            ViewBag.rezultat = Prvi + Drugi;

            return View("Index");
        }

    }
}
