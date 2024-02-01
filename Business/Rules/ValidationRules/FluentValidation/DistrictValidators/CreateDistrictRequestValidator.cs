using Business.Dtos.Requests.DistrictRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.DistrictValidators;

public class CreateDistrictRequestValidator : AbstractValidator<CreateDistrictRequest>
{
    public CreateDistrictRequestValidator()
    {
        RuleFor(d => d.CityId).NotEmpty();

        RuleFor(d => d.Name).NotEmpty();
        RuleFor(d => d.Name).MinimumLength(2);
    }
}
