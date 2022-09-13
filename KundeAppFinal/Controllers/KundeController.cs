using System.Collections.Generic;
using System.Linq;
using KundeAppFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace KundeAppFinal.Controllers
{
    [Route("[controller]/[action]")]
    public class KundeController : ControllerBase
    {
        private readonly KundeContext _db;

        public KundeController(KundeContext db)
        {
            _db = db;
        }

        public List<Kunde> HentAlle()
        {
            try
            {
                List<Kunde> alleKundene = _db.Kunder.ToList();
                return alleKundene;
            }
            catch
            {
                return null;
            }
        }
    }
}
