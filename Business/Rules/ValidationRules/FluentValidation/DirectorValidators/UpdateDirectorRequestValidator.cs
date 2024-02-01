using Business.Dtos.Requests.DirectorRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.DirectorValidators;

public class UpdateDirectorRequestValidator : AbstractValidator<UpdateDirectorRequest>
{
    public UpdateDirectorRequestValidator()
    {
        RuleFor(d => d.FirstName).MinimumLength(2);
        RuleFor(d => d.LastName).MinimumLength(2);
        RuleFor(d => d.Biography).MinimumLength(2);

        RuleFor(d => d.CountryId).NotEmpty();
        RuleFor(d => d.FirstName).NotEmpty();
        RuleFor(d => d.LastName).NotEmpty();
        RuleFor(d => d.Biography).NotEmpty();
        RuleFor(d => d.DateOfBirth).NotEmpty();
    }
}
