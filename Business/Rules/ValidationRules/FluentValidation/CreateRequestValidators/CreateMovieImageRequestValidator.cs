using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateMovieImageRequestValidator : AbstractValidator<CreateMovieImageRequest>
{
    public CreateMovieImageRequestValidator()
    {
        RuleFor(mc => mc.MovieId).NotEmpty();
        RuleFor(mc => mc.ImagePath).NotEmpty();

        RuleFor(mc => mc.ImagePath).MinimumLength(2);
    }
}