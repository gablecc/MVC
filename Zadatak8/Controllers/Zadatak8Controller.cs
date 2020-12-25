using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadatak8.Controllers
{/*Napravite ASP.NET Core MVC aplikaciju Kalkulator koja se sastoji od jednog kontrolera, pet pogleda i jedne layout stranice. Svi pogledi moraju upotrijebiti izrađenu layout stranicu. Jedan kontroler upravlja sa svim pogledima. Aplikacija mora omogućiti izvršavanje osnovnih matematičkih operacija (zbrajanje, oduzimanje, množenje, dijeljenje).

Na pogledima je potrebno ostvariti sljedeće funkcionalnosti:

prvi pogled: ispisati poruku "Ovo je početna stranica aplikacije Kalkualtor"
drugi pogled: omogućiti unos dva broja i ispisati rezultat zbrajanja
treći pogled: omogućiti unos dva broja i ispisati rezultat oduzimanja
četvrti pogled: omogućiti unos dva broja i ispisati rezultat množenja
peti pogled: omogućiti unos dva broja i ispisati rezultat dijeljenja
Layout stranica mora sadržavati izbornik na kojem se moraju nalaziti poveznice prema svakom pogledu (odgovarajućoj akciji na kontroleru).

U aplikaciji implementirati samo funkcionalnosti. Nije obavezna upotreba Bootstrapa.

*/
    public class Zadatak8Controller : Controller
    {
        public IActionResult pocetna()
        {
            return View("pocetna");
        }

        public IActionResult zbrajanje(string prvi, string drugi)
        {
            int.TryParse(prvi, out int Prvi);
            int.TryParse(drugi, out int Drugi);

            ViewBag.rezultat = Prvi + Drugi;


            return View("zbrajanje");
        }

        public IActionResult oduzimanje(string prvi, string drugi)
        {
            int.TryParse(prvi, out int Prvi);
            int.TryParse(drugi, out int Drugi);

            ViewBag.rezultat = Prvi - Drugi;


            return View("oduzimanje");
        }

        public IActionResult mnozenje(string prvi, string drugi)
        {
            int.TryParse(prvi, out int Prvi);
            int.TryParse(drugi, out int Drugi);

            ViewBag.rezultat = Prvi * Drugi;


            return View("mnozenje");
        }

        public IActionResult dijeljenje(string prvi, string drugi)
        {
            int.TryParse(prvi, out int Prvi);
            int.TryParse(drugi, out int Drugi);

            ViewBag.rezultat = Prvi / Drugi;


            return View("dijeljenje");
        }
    }
}
