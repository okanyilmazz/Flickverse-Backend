using Business.Dtos.Requests.AddressRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.AddressValidators;

public class CreateAddressRequestValidator : AbstractValidator<CreateAddressRequest>
{
    public CreateAddressRequestValidator()
    {
        RuleFor(a => a.AddressDetail).MinimumLength(10);

        RuleFor(a => a.AddressDetail).NotEmpty();
        RuleFor(a => a.DistrictId).NotEmpty();
        RuleFor(a => a.CityId).NotEmpty();
        RuleFor(a => a.CountryId).NotEmpty();
    }
}
