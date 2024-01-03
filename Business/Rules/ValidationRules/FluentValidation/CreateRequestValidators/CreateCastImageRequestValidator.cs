using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateCastImageRequestValidator : AbstractValidator<CreateCastImageRequest>
{
    public CreateCastImageRequestValidator()
    {
        RuleFor(ci => ci.CastId).NotEmpty();
        RuleFor(ci => ci.ImagePath).NotEmpty();

        RuleFor(ci => ci.ImagePath).MinimumLength(2);
    }
}
