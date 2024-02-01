using Business.Dtos.Requests.MovieDirectorRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.MovieDirectorValidators;

public class CreateMovieDirectorRequestValidator : AbstractValidator<CreateMovieDirectorRequest>
{
    public CreateMovieDirectorRequestValidator()
    {
        RuleFor(md => md.MovieId).NotEmpty();
        RuleFor(md => md.DirectorId).NotEmpty();
    }
}