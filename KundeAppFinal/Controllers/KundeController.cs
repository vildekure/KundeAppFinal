using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using KundeAppFinal.Models;
using System.Linq;

namespace KundeAppFinal.Controllers
{
    [Route("[controller]/[action]")]
    public class KundeController : ControllerBase
    {
        private readonly KundeDB _kundeDB;

        public KundeController(KundeDB kundeDB)
        {
            _kundeDB = kundeDB;
        }

        public List<Kunde> HentAlle()
        {
            try
            {
                List<Kunde> alleKundene = _kundeDB.Kunder.ToList();
                return alleKundene;
            }
            catch
            {
                return null;
            }
        }
    }
}
