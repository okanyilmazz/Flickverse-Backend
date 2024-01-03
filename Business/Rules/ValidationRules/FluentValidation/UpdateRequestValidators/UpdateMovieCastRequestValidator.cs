using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateMovieCastRequestValidator : AbstractValidator<UpdateMovieCastRequest>
{
    public UpdateMovieCastRequestValidator()
    {
        RuleFor(mc => mc.MovieId).NotEmpty();
        RuleFor(mc => mc.CastId).NotEmpty();
    }
}
