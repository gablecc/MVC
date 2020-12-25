using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadatak5.Controllers
{/*Napravite ASP.NET Core MVC aplikaciju koja omogućuje unos datuma rođenja, te određuje i ispisuje godine starosti.
*/
    public class Zadatak5Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult datum(string prviDatum)
        {
            DateTime.TryParse(prviDatum, out DateTime prvi);



            ViewBag.rezultat = DateTime.Now.Year - prvi.Year  + " godina.";

            return View("Index");
        }
    }
}
