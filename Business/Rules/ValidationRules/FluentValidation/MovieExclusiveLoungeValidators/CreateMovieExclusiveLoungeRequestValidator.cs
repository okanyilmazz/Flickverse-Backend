using Business.Dtos.Requests.MovieExclusiveLoungeRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.MovieExclusiveLoungeValidators;

public class CreateMovieExclusiveLoungeRequestValidator : AbstractValidator<CreateMovieExclusiveLoungeRequest>
{
    public CreateMovieExclusiveLoungeRequestValidator()
    {
        RuleFor(mel => mel.MovieId).NotEmpty();
        RuleFor(mel => mel.ExclusiveLoungeId).NotEmpty();
    }
}
