using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateCinemaHallRequestValidator : AbstractValidator<CreateCinemaHallRequest>
{
    public CreateCinemaHallRequestValidator()
    {
        RuleFor(ch => ch.Description).MinimumLength(10);
        RuleFor(ch => ch.Name).MinimumLength(2);
        RuleFor(ch => ch.Description).NotEmpty();
        RuleFor(ch => ch.Name).NotEmpty();
        RuleFor(ch => ch.AddressId).NotEmpty();
    }
}
