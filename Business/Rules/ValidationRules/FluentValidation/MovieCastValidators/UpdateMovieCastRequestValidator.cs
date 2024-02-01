using Business.Dtos.Requests.MovieCastRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.MovieCastValidators;

public class UpdateMovieCastRequestValidator : AbstractValidator<UpdateMovieCastRequest>
{
    public UpdateMovieCastRequestValidator()
    {
        RuleFor(mc => mc.MovieId).NotEmpty();
        RuleFor(mc => mc.CastId).NotEmpty();
    }
}
