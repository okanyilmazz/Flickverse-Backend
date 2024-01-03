using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateMovieCategoryRequestValidator : AbstractValidator<UpdateMovieCategoryRequest>
{
    public UpdateMovieCategoryRequestValidator()
    {
        RuleFor(mc => mc.MovieId).NotEmpty();
        RuleFor(mc => mc.CategoryId).NotEmpty();
    }
}