using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateMovieCategoryRequestValidator : AbstractValidator<CreateMovieCategoryRequest>
{
    public CreateMovieCategoryRequestValidator()
    {
        RuleFor(mc => mc.MovieId).NotEmpty();
        RuleFor(mc => mc.CategoryId).NotEmpty();
    }
}