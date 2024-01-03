using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateCategoryRequestValidator : AbstractValidator<CreateCategoryRequest>
{
    public CreateCategoryRequestValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.Name).MinimumLength(2);
    }
}
