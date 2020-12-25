using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokvijZadatak4.Controllers
{/*Napravite ASP.NET Core MVC aplikaciju koja sadrži layout stranicu i dva pogleda. Dodajte u projekt Bootstrap i primijenite ga na layout stranici.

U projektu dodajte potrebne izmjene (kontroler) kako bi krajnji korisnik mogao pristupiti pogledima.



Layout stranica mora sadržavati:

pozadinska boja: crna
boja teksta: bijela
header: linkove prema pogledima (akcijama na kontroleru koji vraćaju pogled)


Prvi pogled mora sadržavati tekst "Ovo je početna stranica!" (h2).



Drugi pogled mora sadržavati ime i prezime (upišite svoje ime i prezime, row, centrirano na sredinu stranice).

*/
    public class Zadatak4Controller : Controller
    {
        public IActionResult pocetna()
        {
            return View();
        }

        public IActionResult student()
        {
            return View();
        }
    }
}
