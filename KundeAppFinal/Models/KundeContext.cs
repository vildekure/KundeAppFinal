using Microsoft.EntityFrameworkCore;

namespace KundeAppFinal.Models
{
    public class KundeContext : DbContext
    {
        public KundeContext (DbContextOptions<KundeContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Kunde> Kunder { get; set; }
    }
}
