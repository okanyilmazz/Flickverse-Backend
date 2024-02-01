using Business.Dtos.Requests.LanguageRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.LanguageValidators;

public class CreateLanguageRequestValidator : AbstractValidator<CreateLanguageRequest>
{
    public CreateLanguageRequestValidator()
    {
        RuleFor(l => l.Name).NotEmpty();
        RuleFor(l => l.Name).MinimumLength(2);
    }
}
