using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateCastImageRequestValidator : AbstractValidator<UpdateCastImageRequest>
{
    public UpdateCastImageRequestValidator()
    {
        RuleFor(ci => ci.CastId).NotEmpty();
        RuleFor(ci => ci.ImagePath).NotEmpty();

        RuleFor(ci => ci.ImagePath).MinimumLength(2);
    }
}
