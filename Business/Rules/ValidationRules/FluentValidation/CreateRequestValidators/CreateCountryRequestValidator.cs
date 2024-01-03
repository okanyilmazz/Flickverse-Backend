using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateCountryRequestValidator : AbstractValidator<CreateCountryRequest>
{
    public CreateCountryRequestValidator()
    {
        RuleFor(c => c.Name).MinimumLength(2);
        RuleFor(c => c.Name).NotEmpty();
    }
}
