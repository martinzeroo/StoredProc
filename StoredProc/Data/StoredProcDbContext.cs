using Microsoft.EntityFrameworkCore;
using StoredProc.Models;


namespace StoredProc.Data
{
    public class StoredProcDbContext : DbContext
    {
        public StoredProcDbContext(DbContextOptions<StoredProcDbContext> options)
            : base(options) { }

        public DbSet<Plane> Employee { get; set; }

        public DbSet<StoredProc.Models.Plane> Plane { get; set; }

    }
}
