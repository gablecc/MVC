using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokvijZadatak1.Controllers
{/*Napravite ASP.NET Core MVC aplikaciju koja omogućuje unos dva datuma i ispisuje koliko je dana između unesnih datuma.

Prvi uneseni datum mora biti kalendarski prije drugog unesenog datuma. Ukoliko ovaj uvjet nije zadovoljen, ispisati poruku "Pogrešan unos".*/
    public class Zadatak1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult datumi(string prvi, string drugi)
        {
            DateTime.TryParse(prvi, out DateTime Prvi);
            
            DateTime.TryParse(drugi, out DateTime Drugi);

            if(Prvi>Drugi)
            {
                ViewBag.rezultat = "Pogrešan unos.";
            }
            else
            ViewBag.rezultat = Drugi.Day - Prvi.Day;

            return View("index");
        }
    }
}
