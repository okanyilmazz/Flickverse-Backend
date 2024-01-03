using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateCityRequestValidator : AbstractValidator<CreateCityRequest>
{
    public CreateCityRequestValidator()
    {
        RuleFor(c => c.CountryId).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();

        RuleFor(c => c.Name).MinimumLength(2);
    }
}
