using Business.Dtos.Requests.CountryRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CountryValidators;

public class UpdateCountryRequestValidator : AbstractValidator<UpdateCountryRequest>
{
    public UpdateCountryRequestValidator()
    {
        RuleFor(c => c.Name).MinimumLength(2);
        RuleFor(c => c.Name).NotEmpty();
    }
}
