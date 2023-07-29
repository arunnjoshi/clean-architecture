using MediatR;

namespace Gangster.Application.Gangster.Commands.CreateGangsterHandler;

public class CreateGangsterRequest : IRequest<CreateGangsterResponse>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateOnly DOB { get; set; }
}

public class CreateGangsterResponse : CreateGangsterRequest
{
    public int Id { get; set; }
}

public class CreateGangsterHandler : IRequestHandler<CreateGangsterRequest,  CreateGangsterResponse>
{
    public async Task<CreateGangsterResponse> Handle(CreateGangsterRequest request, CancellationToken cancellationToken)
    {
        return new CreateGangsterResponse { Id = 20,FirstName = "arun",LastName = "joshi",DOB=DateOnly.FromDateTime(DateTime.Now) };
    }
}
