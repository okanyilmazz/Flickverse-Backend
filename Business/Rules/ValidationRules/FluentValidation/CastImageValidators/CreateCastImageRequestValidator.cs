using Business.Dtos.Requests.CastImageRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CastImageValidators;

public class CreateCastImageRequestValidator : AbstractValidator<CreateCastImageRequest>
{
    public CreateCastImageRequestValidator()
    {
        RuleFor(ci => ci.CastId).NotEmpty();
        RuleFor(ci => ci.ImagePath).NotEmpty();

        RuleFor(ci => ci.ImagePath).MinimumLength(2);
    }
}
