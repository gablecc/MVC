using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadatak4.Controllers
{/*Napravite ASP.NET Core MVC aplikaciju koja omogućuje unos jednog cijelog broja (ocjena), te ispisuje njenu opisnu vrijednost (nedovoljan, dovoljan, dobar, vrlo dobar, izvrstan).

Ukoliko se unese broj koji ne predstavlja ocjenu, aplikacija mora ispisati poruku o pogrešnom unosu.*/

    public class Zadatak4Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ocjena(string ocjena)
        {
            
            int.TryParse(ocjena, out int a);

            switch (a)
            {
                case 1:
                    ViewBag.rezultat = a + ", nedovoljan.";
                    break;
                case 2:
                    ViewBag.rezultat = a + ", dovoljan.";
                    break;
                case 3:
                    ViewBag.rezultat = a + ", dobar.";
                    break;
                case 4:
                    ViewBag.rezultat = a + ", vrlo dobar.";
                    break;
                case 5:
                    ViewBag.rezultat = a + ", odličan.";
                    break;
                default:
                    ViewBag.rezultat = "Pogrešan format ocjene";
                    break;

            }


            return View("Index");
        }
    }

}
