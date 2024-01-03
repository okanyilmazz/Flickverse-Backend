using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateLanguageRequestValidator : AbstractValidator<CreateLanguageRequest>
{
    public CreateLanguageRequestValidator()
    {
        RuleFor(l => l.Name).NotEmpty();
        RuleFor(l => l.Name).MinimumLength(2);
    }
}
