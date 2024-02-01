using Business.Dtos.Requests.CategoryRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CategoryValidators;

public class UpdateCategoryRequestValidator : AbstractValidator<UpdateCategoryRequest>
{
    public UpdateCategoryRequestValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.Name).MinimumLength(2);
    }
}
