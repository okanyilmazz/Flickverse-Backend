using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateCinemaHallExclusiveLoungeRequestValidator : AbstractValidator<UpdateCinemaHallExclusiveLoungeRequest>
{
    public UpdateCinemaHallExclusiveLoungeRequestValidator()
    {
        RuleFor(chel => chel.CinemaHallId).NotEmpty();
        RuleFor(chel => chel.ExclusiveLoungeId).NotEmpty();
    }
}
