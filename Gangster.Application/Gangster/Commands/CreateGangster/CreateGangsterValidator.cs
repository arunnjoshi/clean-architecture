// Ignore Spelling: Validator

using FluentValidation;
using Gangster.Application.Gangster.Commands.CreateGangsterHandler;

namespace Gangster.Application.Gangster.Commands.CreateGangster;

public class CreateGangsterValidator : AbstractValidator<CreateGangsterRequest>
{
    public CreateGangsterValidator()
    {
        RuleFor(v => v.FirstName)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotEmpty()
            .MinimumLength(3)
            .WithMessage("First name should be at least 3 character.")
            .MaximumLength(20)
            .WithMessage("First name max length should be 20 character.");

        RuleFor(v => v.LastName)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotEmpty()
           .MinimumLength(3)
           .WithMessage("Last name should be at least 3 character.")
           .MaximumLength(20)
           .WithMessage("Last name max length should be 20 character.")
           .NotEmpty();

        RuleFor(v => v.DOB)
            .NotNull();
    }
}
