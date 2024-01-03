using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateExclusiveLoungeRequestValidator : AbstractValidator<CreateExclusiveLoungeRequest>
{
    public CreateExclusiveLoungeRequestValidator()
    {
        RuleFor(el => el.Name).NotEmpty();
        RuleFor(el => el.Description).NotEmpty();

        RuleFor(el => el.Name).MinimumLength(2);
        RuleFor(el => el.Description).MinimumLength(10);
    }
}
