using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using KundeApp2ver2.Models;
using System.Linq;

namespace KundeAppFinal.Controllers
{
    [Route("[controller]/[action]")]
    public class KundeController : ControllerBase
    {
        public List<Kunde> HentAlle()
        {
            var kundene = new List<Kunde>();

            var kunde1 = new Kunde();
            kunde1.navn = "Per Hansen";
            kunde1.adresse = "Osloveien 2";

            var kunde2 = new Kunde
            {
                navn = "Line Jensen",
                adresse = "Askerveien 82"
            };

            return kundene;
        }
    }
}
