using MediatR;

namespace Clean.Application.Demo.Queries
{
    public class GetDemoQuery : IRequest<List<GetDemoResponse>>
    {
    }
}
