using Itinere.Infrastructure.Ef.Configurations;
using Itinere.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace Itinere.Infrastructure.Ef
{
    public class ItinereDbContext : DbContext
    {
        public ItinereDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Footprint> Footprints { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new FootprintConfiguration());
            modelBuilder.ApplyConfiguration(new CoffeeTimeConfiguration());
        }
    }
}
