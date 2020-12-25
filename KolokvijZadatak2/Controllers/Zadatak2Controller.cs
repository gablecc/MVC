using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokvijZadatak2.Controllers
{/*
    Napravite ASP.NET Core MVC aplikaciju koja omogućuje unos tri cijela broja i ispisuje koliko je istih vrijednosti uneseno.


   Za ispis rezultata upotrijebite jednu od sljedećih poruka (ovisno o rezultatu):

Unesene su ___ iste vrijednosti.
Sve unesene vrijednosti su različite.
    */
    public class Zadatak2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult vrijednosti(string prvi, string drugi, string treci)
        {
            int.TryParse(prvi, out int Prvi);
            int.TryParse(drugi, out int Drugi);
            int.TryParse(treci, out int Treci);

            if (Prvi == Drugi && Prvi == Treci)
            {
                ViewBag.rezultat = "Sve tri vrijednosti su jednake.";
            }


            else if (Prvi==Drugi || Treci==Prvi || Drugi==Treci)
            {
                ViewBag.rezultat = "Dvije vrijednosti su jednake.";
            }

            
            else
            {
                ViewBag.rezultat = "Vrijednosti nisu jednake";
            }

            return View("index");
        }
    }
}
