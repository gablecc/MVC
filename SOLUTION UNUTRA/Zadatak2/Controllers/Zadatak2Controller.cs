using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadatak2.Controllers
{/*Napravite ASP.NET Core MVC aplikaciju koja omogućuje unos za tri broja, te računa i ispisuje zbroj učitanih brojeva.*/
    public class Zadatak2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult zbrajanje(string prvi, string drugi, string treci)
        {

            int.TryParse(prvi, out int Prvi);
            int.TryParse(drugi, out int Drugi);
            int.TryParse(treci, out int Treci);

            ViewBag.rezultat = Prvi + Drugi + Treci;

            return View("Index");
        }
    }
}
