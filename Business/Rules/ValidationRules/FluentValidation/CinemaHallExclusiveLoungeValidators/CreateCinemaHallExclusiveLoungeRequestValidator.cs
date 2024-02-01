using Business.Dtos.Requests.CinemaHallExclusiveLoungeRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CinemaHallExclusiveLoungeValidators;

public class CreateCinemaHallExclusiveLoungeRequestValidator : AbstractValidator<CreateCinemaHallExclusiveLoungeRequest>
{
    public CreateCinemaHallExclusiveLoungeRequestValidator()
    {
        RuleFor(chel => chel.CinemaHallId).NotEmpty();
        RuleFor(chel => chel.ExclusiveLoungeId).NotEmpty();
    }
}
