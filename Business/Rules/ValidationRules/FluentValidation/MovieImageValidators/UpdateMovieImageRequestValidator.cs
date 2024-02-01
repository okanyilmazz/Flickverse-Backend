using Business.Dtos.Requests.MovieImageRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.MovieImageValidators;

public class UpdateMovieImageRequestValidator : AbstractValidator<UpdateMovieImageRequest>
{
    public UpdateMovieImageRequestValidator()
    {
        RuleFor(mc => mc.MovieId).NotEmpty();
        RuleFor(mc => mc.ImagePath).NotEmpty();

        RuleFor(mc => mc.ImagePath).MinimumLength(2);
    }
}