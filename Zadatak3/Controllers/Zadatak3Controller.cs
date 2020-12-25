using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadatak3.Controllers
{/*Napravite ASP.NET Core MVC aplikaciju koja omogućuje unos za dva broja, te računa i ispisuje zbroj učitanih brojeva.

Aplikacija mora ispisati da li je izračunati zbroj pozitivan broj, negativan broj ili nula.*/
    public class Zadatak3Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult zbrajanje(string prvi, string drugi)
        {

            int.TryParse(prvi, out int Prvi);
            int.TryParse(drugi, out int Drugi);

            int zbroj = Prvi + Drugi;

            if (zbroj > 0)
                ViewBag.rezultat = "Zbroj Vaših brojeva je: " +zbroj + " Vaš zbroj je pozitivan.";

            if (zbroj == 0)
                ViewBag.rezultat ="Vaš zbroj je nula.";

            if (zbroj<0) 
                ViewBag.rezultat= "Zbroj Vaših brojeva je: " +zbroj+ " Vaš zbroj je negativan.";


            return View("Index");
        }
    }
}
