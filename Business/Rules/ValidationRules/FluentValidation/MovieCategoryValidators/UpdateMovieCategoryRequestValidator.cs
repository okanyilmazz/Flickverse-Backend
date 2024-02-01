using Business.Dtos.Requests.MovieCategoryRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.MovieCategoryValidators;

public class UpdateMovieCategoryRequestValidator : AbstractValidator<UpdateMovieCategoryRequest>
{
    public UpdateMovieCategoryRequestValidator()
    {
        RuleFor(mc => mc.MovieId).NotEmpty();
        RuleFor(mc => mc.CategoryId).NotEmpty();
    }
}