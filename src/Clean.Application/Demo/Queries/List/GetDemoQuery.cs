using Clean.Application.Common.Response;
using MediatR;

namespace Clean.Application.Demo.Queries.List
{
    public class GetDemoQuery : IRequest<ApiResponse<List<GetDemoResponse>>>
    {
    }
}
