using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KundeAppFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

         public async Task<bool> Lagre(Kunde innKunde)
        {
            try
            {
                _db.Kunder.Add(innKunde);
                await _db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

       public async Task<List<Kunde>> HentAlle()
        {
            try
            {
                List<Kunde> alleKundene = await _db.Kunder.ToListAsync();
                return alleKundene;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> Slett(int id)
        {
            try
            {
                Kunde enKunde = await _db.Kunder.FindAsync(id);
                _db.Kunder.Remove(enKunde);
                await _db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<Kunde> HentEn(int id)
        {
            try
            {
                Kunde enKunde = await _db.Kunder.FindAsync(id);
                return enKunde;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> Endre(Kunde endreKunde)
        {
            try
            {
                Kunde enKunde = await _db.Kunder.FindAsync(endreKunde.id);
                enKunde.navn = endreKunde.navn;
                enKunde.adresse = endreKunde.adresse;
                await _db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
