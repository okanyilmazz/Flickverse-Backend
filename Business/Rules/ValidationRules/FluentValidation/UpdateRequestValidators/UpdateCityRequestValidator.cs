using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateCityRequestValidator : AbstractValidator<UpdateCityRequest>
{
    public UpdateCityRequestValidator()
    {
        RuleFor(c => c.CountryId).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();

        RuleFor(c => c.Name).MinimumLength(2);
    }
}