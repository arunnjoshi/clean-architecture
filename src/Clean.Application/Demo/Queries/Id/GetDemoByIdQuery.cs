using Clean.Application.Common.Response;
using Clean.Application.Demo.Queries.List;
using MediatR;

namespace Clean.Application.Demo.Queries.Id
{
    public class GetDemoByIdQuery : IRequest<ApiResponse<GetDemoResponse>>
    {
        public Guid Id { get; set; }
    }
}
