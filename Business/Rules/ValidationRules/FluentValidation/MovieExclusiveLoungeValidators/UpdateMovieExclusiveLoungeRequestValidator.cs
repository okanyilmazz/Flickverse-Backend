using Business.Dtos.Requests.MovieExclusiveLoungeRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.MovieExclusiveLoungeValidators;

public class UpdateMovieExclusiveLoungeRequestValidator : AbstractValidator<UpdateMovieExclusiveLoungeRequest>
{
    public UpdateMovieExclusiveLoungeRequestValidator()
    {
        RuleFor(mel => mel.MovieId).NotEmpty();
        RuleFor(mel => mel.ExclusiveLoungeId).NotEmpty();
    }
}
