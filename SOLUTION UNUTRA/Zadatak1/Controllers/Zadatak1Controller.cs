using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadatak1.Controllers
{/*Napravite ASP.NET Core MVC aplikaciju koja omogućuje unos imena i prezimena, te ispisuje učitano ime i prezime.*/
    public class Zadatak1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult imePrezime(string ime, string prezime)
        {

            var reza = ime +" "+ prezime;
            ViewBag.rezultat = reza;


            return View("Index");
        }
    }
}
