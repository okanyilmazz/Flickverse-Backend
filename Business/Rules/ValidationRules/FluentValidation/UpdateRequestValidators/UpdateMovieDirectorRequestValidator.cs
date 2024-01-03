using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateMovieDirectorRequestValidator : AbstractValidator<UpdateMovieDirectorRequest>
{
    public UpdateMovieDirectorRequestValidator()
    {
        RuleFor(md => md.MovieId).NotEmpty();
        RuleFor(md => md.DirectorId).NotEmpty();
    }
}