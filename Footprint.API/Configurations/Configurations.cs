using Footprint.Infrastructure.Ef;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Footprint.API
{
    public static class Configurations
    {
        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["mysqlconnection:connectionString"];
            services.AddDbContext<FootprintDbContext>(o => o.UseMySQL(connectionString));
        }
    }
}
