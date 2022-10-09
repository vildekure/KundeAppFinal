using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Castle.Core.Logging;
using KundeAppFinal.DAL;
using KundeAppFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace KundeAppFinal.Controllers
{
    [Route("[controller]/[action]")]
    public class KundeController : ControllerBase
    {
        private readonly IKundeRepository _db;

        private readonly ILogger<KundeController> _log;

        public KundeController(IKundeRepository db, ILogger<KundeController> log)
        {
            _db = db;
            _log = log;
        }

        public async Task<bool> Lagre(Kunde innKunde)
        {
            return await _db.Lagre(innKunde);
        }

        public async Task<List<Kunde>> HentAlle()
        {
            _log.LogInformation("Test Log");
            return await _db.HentAlle();
        }

        public async Task<bool> Slett(int id)
        {
            return await _db.Slett(id);
        }

        public async Task<Kunde> HentEn(int id)
        {
            return await _db.HentEn(id);
        }

        public async Task<bool> Endre(Kunde endreKunde)
        {
            return await _db.Endre(endreKunde);
        }

    }
}
