using Clean.Application.Common.Interfaces;
using Clean.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Demo.Queries
{
    public class GetDemoQueryHandler : IRequestHandler<GetDemoQuery, List<GetDemoResponse>>
    {
        private readonly IApplicationDbContext dbContext;

        public GetDemoQueryHandler(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<GetDemoResponse>> Handle(GetDemoQuery request, CancellationToken cancellationToken)
        {
            return await dbContext.Demo.Select(x => new GetDemoResponse { Id = x.Id, DOB = x.DOB, Name = x.Name }).ToListAsync(); ;
        }
    }
}
