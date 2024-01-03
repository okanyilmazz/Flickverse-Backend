using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateExclusiveLoungeRequestValidator : AbstractValidator<UpdateExclusiveLoungeRequest>
{
    public UpdateExclusiveLoungeRequestValidator()
    {
        RuleFor(el => el.Name).NotEmpty();
        RuleFor(el => el.Description).NotEmpty();

        RuleFor(el => el.Name).MinimumLength(2);
        RuleFor(el => el.Description).MinimumLength(10);
    }
}
