using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateMovieExclusiveLoungeRequestValidator : AbstractValidator<UpdateMovieExclusiveLoungeRequest>
{
    public UpdateMovieExclusiveLoungeRequestValidator()
    {
        RuleFor(mel => mel.MovieId).NotEmpty();
        RuleFor(mel => mel.ExclusiveLoungeId).NotEmpty();
    }
}
