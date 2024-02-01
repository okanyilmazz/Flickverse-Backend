using Business.Dtos.Requests.CinemaHallExclusiveLoungeRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CinemaHallExclusiveLoungeValidators;

public class UpdateCinemaHallExclusiveLoungeRequestValidator : AbstractValidator<UpdateCinemaHallExclusiveLoungeRequest>
{
    public UpdateCinemaHallExclusiveLoungeRequestValidator()
    {
        RuleFor(chel => chel.CinemaHallId).NotEmpty();
        RuleFor(chel => chel.ExclusiveLoungeId).NotEmpty();
    }
}
