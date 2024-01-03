using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateCastRequestValidator : AbstractValidator<CreateCastRequest>
{
    public CreateCastRequestValidator()
    {
        RuleFor(c => c.FirstName).MinimumLength(2);
        RuleFor(c => c.LastName).MinimumLength(2);
        RuleFor(c => c.Biography).MinimumLength(2);

        RuleFor(c => c.CountryId).NotEmpty();
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(c => c.Biography).NotEmpty();
        RuleFor(c => c.DateOfBirth).NotEmpty();
    }
}
