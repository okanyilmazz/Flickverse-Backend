using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

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
