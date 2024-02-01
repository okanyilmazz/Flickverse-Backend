using Business.Dtos.Requests.MovieCastRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.MovieCastValidators;

public class CreateMovieCastRequestValidator : AbstractValidator<CreateMovieCastRequest>
{
    public CreateMovieCastRequestValidator()
    {
        RuleFor(mc => mc.MovieId).NotEmpty();
        RuleFor(mc => mc.CastId).NotEmpty();
    }
}
