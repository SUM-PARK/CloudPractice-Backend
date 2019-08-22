using Footprint.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace Footprint.Infrastructure.Ef
{
    public class FootprintDbContext : DbContext
    {
        public FootprintDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DailyFootprint> Footprints { get; set; }
    }
}
