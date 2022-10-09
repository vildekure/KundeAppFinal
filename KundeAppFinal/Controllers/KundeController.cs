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

        public async Task<ActionResult> Lagre(Kunde innKunde)
        {
            bool returOK =  await _db.Lagre(innKunde);
            if(!returOK)
            {
                _log.LogInformation("Kunden ble ikke lagret");
                return BadRequest("Kunden ble ikke lagret");
            }
            return Ok("Kunde lagret");
        }

        public async Task<ActionResult> HentAlle()
        {
            List<Kunde> alleKunder = await _db.HentAlle();
            return Ok(alleKunder);
        }

        public async Task<ActionResult> Slett(int id)
        {
            bool returOK = await _db.Slett(id);
            if (!returOK)
            {
                _log.LogInformation("Kunden ble ikke slettet");
                return NotFound("Kunden ble ikke slettet");
            }
            return Ok("Kunde slettet");
        }

        public async Task<ActionResult> HentEn(int id)
        {
            Kunde enKunde = await _db.HentEn(id);
            if (enKunde == null)
            {
                _log.LogInformation("Fant ikke Kunden");
                return NotFound("Fant ikke kunden");
            }
            return Ok("Kunde funnet");
        }

        public async Task<ActionResult> Endre(Kunde endreKunde)
        {
            bool returOK = await _db.Endre(endreKunde);
            if (!returOK)
            {
                _log.LogInformation("Kunden ble ikke endret");
                return NotFound("Kunden ble ikke endret");
            }
            return Ok("KJunden endret");
        }

    }
}
