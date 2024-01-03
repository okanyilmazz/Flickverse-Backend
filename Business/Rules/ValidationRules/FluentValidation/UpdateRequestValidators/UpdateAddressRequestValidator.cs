using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateAddressRequestValidator : AbstractValidator<UpdateAddressRequest>
{
    public UpdateAddressRequestValidator()
    {
        RuleFor(a => a.AddressDetail).MinimumLength(10);

        RuleFor(a => a.AddressDetail).NotEmpty();
        RuleFor(a => a.DistrictId).NotEmpty();
        RuleFor(a => a.CityId).NotEmpty();
        RuleFor(a => a.CountryId).NotEmpty();
    }
}
