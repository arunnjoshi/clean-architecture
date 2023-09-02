using Clean.Domain.Entitles;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Common.Interfaces
{
	public interface IApplicationDbContext
    {
        DbSet<DemoEntity> Demo { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
