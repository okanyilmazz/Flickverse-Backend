using Business.Dtos.Requests.DirectorImageRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.DirectorImageValidators;

public class UpdateDirectorImageRequestValidator : AbstractValidator<UpdateDirectorImageRequest>
{
    public UpdateDirectorImageRequestValidator()
    {
        RuleFor(di => di.DirectorId).NotEmpty();
        RuleFor(di => di.ImagePath).NotEmpty();

        RuleFor(di => di.ImagePath).MinimumLength(2);
    }
}
