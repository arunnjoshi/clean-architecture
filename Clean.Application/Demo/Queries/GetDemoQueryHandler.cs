using AutoMapper;
using Clean.Application.Common.Authentication;
using Clean.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Demo.Queries
{
    public class GetDemoQueryHandler : IRequestHandler<GetDemoQuery, List<GetDemoResponse>>
    {
        private readonly IApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetDemoQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetDemoResponse>> Handle(GetDemoQuery request, CancellationToken cancellationToken)
        {
            var demos = await _dbContext.Demo.AsNoTracking().ToListAsync(cancellationToken);
            return _mapper.Map<List<GetDemoResponse>>(demos); ;
        }
    }
}
