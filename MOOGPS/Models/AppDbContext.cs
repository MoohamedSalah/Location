using Microsoft.EntityFrameworkCore;

namespace MOOGPS.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext( DbContextOptions options):base(options)
        {

        }
        public virtual DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Location>().Property(a => a.latitude).HasColumnType("decimal").HasPrecision(18, 4);
            modelBuilder.Entity<Location>().Property(a => a.longitude).HasColumnType("decimal").HasPrecision(18, 4);
        }

    }
}
