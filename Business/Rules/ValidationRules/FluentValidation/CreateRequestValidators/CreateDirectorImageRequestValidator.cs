using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateDirectorImageRequestValidator : AbstractValidator<CreateDirectorImageRequest>
{
    public CreateDirectorImageRequestValidator()
    {
        RuleFor(di => di.DirectorId).NotEmpty();
        RuleFor(di => di.ImagePath).NotEmpty();

        RuleFor(di => di.ImagePath).MinimumLength(2);
    }
}
