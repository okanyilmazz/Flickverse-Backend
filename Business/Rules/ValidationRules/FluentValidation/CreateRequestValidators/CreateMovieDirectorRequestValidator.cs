using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateMovieDirectorRequestValidator : AbstractValidator<CreateMovieDirectorRequest>
{
    public CreateMovieDirectorRequestValidator()
    {
        RuleFor(md => md.MovieId).NotEmpty();
        RuleFor(md => md.DirectorId).NotEmpty();
    }
}