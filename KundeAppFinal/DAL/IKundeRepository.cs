using KundeAppFinal.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KundeAppFinal.DAL
{
    public interface IKundeRepository
    {

        Task<bool> Lagre(Kunde innKunde);
        Task<List<Kunde>> HentAlle();
        Task<bool> Slett(int id);
        Task<Kunde> HentEn(int id);
        Task<bool> Endre(Kunde endreKunde);

    }
}
