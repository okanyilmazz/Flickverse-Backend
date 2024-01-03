using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateDirectorImageRequestValidator : AbstractValidator<UpdateDirectorImageRequest>
{
    public UpdateDirectorImageRequestValidator()
    {
        RuleFor(di => di.DirectorId).NotEmpty();
        RuleFor(di => di.ImagePath).NotEmpty();

        RuleFor(di => di.ImagePath).MinimumLength(2);
    }
}
