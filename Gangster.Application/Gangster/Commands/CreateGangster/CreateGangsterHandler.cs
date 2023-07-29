using Gangster.ApiModel.ApiResponse;
using MediatR;

namespace Gangster.Application.Gangster.Commands.CreateGangsterHandler;

public class CreateGangsterRequest : IRequest<APIResponse<CreateGangsterResponse>>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateOnly DOB { get; set; }
}

public class CreateGangsterResponse : CreateGangsterRequest
{
    public int Id { get; set; }
}

public class CreateGangsterHandler : IRequestHandler<CreateGangsterRequest, APIResponse<CreateGangsterResponse>>
{
    public Task<APIResponse<CreateGangsterResponse>> Handle(CreateGangsterRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult(APIResponse<CreateGangsterResponse>.SendResponse(200, "", new CreateGangsterResponse
        {
            Id = 1,
            FirstName = request.FirstName,
            LastName = request.LastName,
            DOB = request.DOB,
        },
        true));
    }
}
