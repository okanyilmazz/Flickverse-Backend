using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateMovieCastRequestValidator : AbstractValidator<CreateMovieCastRequest>
{
    public CreateMovieCastRequestValidator()
    {
        RuleFor(mc => mc.MovieId).NotEmpty();
        RuleFor(mc => mc.CastId).NotEmpty();
    }
}
