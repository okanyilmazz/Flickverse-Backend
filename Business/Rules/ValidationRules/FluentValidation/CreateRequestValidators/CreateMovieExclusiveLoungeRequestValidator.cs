using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateMovieExclusiveLoungeRequestValidator : AbstractValidator<CreateMovieExclusiveLoungeRequest>
{
    public CreateMovieExclusiveLoungeRequestValidator()
    {
        RuleFor(mel => mel.MovieId).NotEmpty();
        RuleFor(mel => mel.ExclusiveLoungeId).NotEmpty();
    }
}
