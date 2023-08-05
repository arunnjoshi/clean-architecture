using Gangster.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Gangster.Infrastructure
{
    public static class ConfigureServices
    {
        // dotnet ef migrations add "SampleMigration" --project ./Gangster.Infrastructure --startup-project Gangster.WebApi --output-dir Data/Migrations
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>();
            return services;
        }
    }
}
