using FluentValidation;

namespace Clean.Application.Demo.Queries;

public class GetDemoQueryValidators : AbstractValidator<GetDemoQuery>
{
    public GetDemoQueryValidators()
    {
    }
}
