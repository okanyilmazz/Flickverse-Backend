using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateDistrictRequestValidator : AbstractValidator<UpdateDistrictRequest>
{
    public UpdateDistrictRequestValidator()
    {
        RuleFor(d => d.CityId).NotEmpty();

        RuleFor(d => d.Name).NotEmpty();
        RuleFor(d => d.Name).MinimumLength(2);
    }
}
