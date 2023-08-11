using FluentValidation;

namespace Clean.Application.Demo.Queries.Id;

public class GetDemoByIdQueryValidator : AbstractValidator<GetDemoByIdQuery>
{
    public GetDemoByIdQueryValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .NotEmpty()
            .WithMessage("This field is required.");
    }
}
