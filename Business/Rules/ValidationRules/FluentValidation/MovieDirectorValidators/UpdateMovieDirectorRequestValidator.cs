using Business.Dtos.Requests.MovieDirectorRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.MovieDirectorValidators;

public class UpdateMovieDirectorRequestValidator : AbstractValidator<UpdateMovieDirectorRequest>
{
    public UpdateMovieDirectorRequestValidator()
    {
        RuleFor(md => md.MovieId).NotEmpty();
        RuleFor(md => md.DirectorId).NotEmpty();
    }
}