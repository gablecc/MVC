using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadatak7.Controllers
{/*Napravite ASP.NET Core MVC aplikaciju koja se sastoji od jednog kontrolera, tri pogleda i jedne layout stranice. Sva tri pogleda moraju upotrijebiti izrađenu layout stranicu. Jedan kontroler upravlja sa sva tri pogleda.

Na pogledima moraju biti ispisani sljedeći podaci i naslov:

prvi pogled: "Ovo je početna stranica"
drugi pogled: Vaše ime i prezime
treći pogled: naziv velečilišta
Layout stranica mora sadržavati izbornik na kojem se moraju nalaziti poveznice prema svakom pogledu (odgovarajućoj akciji na kontroleru).

Pri izradi pogleda i layout stranice upotrijebiti Bootstrap.*/
    public class Zadatak7Controller : Controller
    {
        

        public IActionResult pocetna()
        {
            return View();
        }

        public IActionResult oMeni()
        {
            return View();
        }

        public IActionResult veleuciliste()
        {
            return View();
        }
    }
}
