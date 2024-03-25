using AutoMapper;
using Clean.Application.Common.Interfaces;
using Clean.Application.Common.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Demo.Queries.List
{
    public class GetDemoQueryHandler : IRequestHandler<GetDemoQuery, ApiResponse<List<GetDemoResponse>>>
    {
        private readonly IApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetDemoQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ApiResponse<List<GetDemoResponse>>> Handle(GetDemoQuery request, CancellationToken cancellationToken)
        {
            var demos = await _dbContext.Demo.AsNoTracking().ToListAsync(cancellationToken);
            var data = _mapper.Map<List<GetDemoResponse>>(demos);
            return ApiResponse<List<GetDemoResponse>>.SendResponse(data, "successful", true, StatusCodes.Status200OK);
        }
    }
}
