﻿using System.Collections.Generic;
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

        public bool Lagre(Kunde innKunde)
        {
            try
            {
                _db.Kunder.Add(innKunde);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }



        public Kunde HentEn(int Id)
        {
            try
            {
                Kunde enKunde = _db.Kunder.Find(Id);
                return enKunde;
            }
            catch
            {
                return null;
            }
        }

        public bool Endre(Kunde endreKunde)
        {
            try
            {
                Kunde enKunde = _db.Kunder.Find(endreKunde.Id);
                enKunde.navn = endreKunde.navn;
                enKunde.adresse = endreKunde.adresse;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
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

        public bool Slett(int Id)
        {
            try
            {
                Kunde enKunde = _db.Kunder.Find(Id);
                _db.Kunder.Remove(enKunde);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
