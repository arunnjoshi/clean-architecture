using Clean.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Clean.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            var connectionString = "server=(localdb)\\mssqllocaldb;Database=Demo;Trusted_Connection=True;";

            services.AddDbContext<ApplicationDbContext>((sp, options) =>
            {
                options.UseSqlServer(connectionString);
            });
            return services;
        }
    }
}
