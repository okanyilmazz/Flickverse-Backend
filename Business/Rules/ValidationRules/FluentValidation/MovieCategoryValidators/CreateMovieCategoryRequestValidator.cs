using Business.Dtos.Requests.MovieCategoryRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.MovieCategoryValidators;

public class CreateMovieCategoryRequestValidator : AbstractValidator<CreateMovieCategoryRequest>
{
    public CreateMovieCategoryRequestValidator()
    {
        RuleFor(mc => mc.MovieId).NotEmpty();
        RuleFor(mc => mc.CategoryId).NotEmpty();
    }
}