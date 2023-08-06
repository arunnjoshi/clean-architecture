using Clean.Application;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Clean.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Demo> Demo => Set<Demo>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }

    }
}
