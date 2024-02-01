using Business.Dtos.Requests.CountryRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CountryValidators;

public class CreateCountryRequestValidator : AbstractValidator<CreateCountryRequest>
{
    public CreateCountryRequestValidator()
    {
        RuleFor(c => c.Name).MinimumLength(2);
        RuleFor(c => c.Name).NotEmpty();
    }
}
