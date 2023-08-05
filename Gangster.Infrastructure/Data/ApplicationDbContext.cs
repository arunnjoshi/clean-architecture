using Gangster.ApiModel.Gangster;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Gangster.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<GangsterModel> Gangster => Set<GangsterModel>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure SQLite
            optionsBuilder.UseSqlite("Data Source=Gangster.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
