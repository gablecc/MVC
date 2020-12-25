using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokvijZadatak3.Controllers
{/*Napravite ASP.NET Core MVC aplikaciju koja sadrži pogled dizajniran prema opisu i slici u nastavku. Dodajte u projekt Bootstrap i primijenite ga na pogledu.

U projektu dodajte potrebne izmjene (kontroler) kako bi krajnji korisnik mogao pristupiti pogledu.

Pogled mora sadržavati:

pozadinska boja: narančasta
header: "Moja aplikacija", h2, row, centrirano na sredinu stranice, horizontalna linija, boja teksta: bijela
tablicu sa zaglavljem: table table-hover
footer: horizontalna linija, ime i prezime (upišite svoje ime i prezime), row, centrirano na sredinu stranice, boja teksta: bijela*/
    public class Zadatak3Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
