using Business.Dtos.Requests.LanguageRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.LanguageValidators;

public class UpdateLanguageRequestValidator : AbstractValidator<UpdateLanguageRequest>
{
    public UpdateLanguageRequestValidator()
    {
        RuleFor(l => l.Name).NotEmpty();
        RuleFor(l => l.Name).MinimumLength(2);
    }
}
