using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateCastRequestValidator : AbstractValidator<UpdateCastRequest>
{
    public UpdateCastRequestValidator()
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
