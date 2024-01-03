using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateLanguageRequestValidator : AbstractValidator<UpdateLanguageRequest>
{
    public UpdateLanguageRequestValidator()
    {
        RuleFor(l => l.Name).NotEmpty();
        RuleFor(l => l.Name).MinimumLength(2);
    }
}
