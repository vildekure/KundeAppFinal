using Microsoft.EntityFrameworkCore;

namespace KundeAppFinal.Models
{
    public class KundeDB : DbContext
    {
        public KundeDB (DbContextOptions<KundeDB> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Kunde> Kunder { get; set; }
    }
}
