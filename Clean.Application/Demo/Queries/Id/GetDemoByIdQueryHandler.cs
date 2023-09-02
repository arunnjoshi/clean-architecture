using AutoMapper;
using Clean.Application.Common.Interfaces;
using Clean.Application.Common.Response;
using Clean.Application.Demo.Queries.List;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Demo.Queries.Id
{
    public class GetDemoByIdQueryHandler : IRequestHandler<GetDemoByIdQuery, ApiResponse<GetDemoResponse>>
    {

        private readonly IApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetDemoByIdQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ApiResponse<GetDemoResponse>> Handle(GetDemoByIdQuery request, CancellationToken cancellationToken)
        {
            var demo = await _dbContext.Demo.FirstOrDefaultAsync(x => x.Id == request.Id);
            return ApiResponse<GetDemoResponse>.sendResponse(data: _mapper.Map<GetDemoResponse>(demo), "successful", true, (int)StatusCodes.Status200OK);
        }
    }
}
