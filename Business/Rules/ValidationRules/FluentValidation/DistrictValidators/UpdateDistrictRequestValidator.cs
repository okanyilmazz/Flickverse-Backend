using Business.Dtos.Requests.DistrictRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.DistrictValidators;

public class UpdateDistrictRequestValidator : AbstractValidator<UpdateDistrictRequest>
{
    public UpdateDistrictRequestValidator()
    {
        RuleFor(d => d.CityId).NotEmpty();

        RuleFor(d => d.Name).NotEmpty();
        RuleFor(d => d.Name).MinimumLength(2);
    }
}
