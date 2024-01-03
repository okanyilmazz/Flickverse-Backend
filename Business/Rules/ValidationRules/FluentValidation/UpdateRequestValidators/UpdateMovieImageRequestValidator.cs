using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateMovieImageRequestValidator : AbstractValidator<UpdateMovieImageRequest>
{
    public UpdateMovieImageRequestValidator()
    {
        RuleFor(mc => mc.MovieId).NotEmpty();
        RuleFor(mc => mc.ImagePath).NotEmpty();

        RuleFor(mc => mc.ImagePath).MinimumLength(2);
    }
}