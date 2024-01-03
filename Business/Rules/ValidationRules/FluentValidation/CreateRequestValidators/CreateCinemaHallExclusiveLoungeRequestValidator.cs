using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateCinemaHallExclusiveLoungeRequestValidator : AbstractValidator<CreateCinemaHallExclusiveLoungeRequest>
{
    public CreateCinemaHallExclusiveLoungeRequestValidator()
    {
        RuleFor(chel => chel.CinemaHallId).NotEmpty();
        RuleFor(chel => chel.ExclusiveLoungeId).NotEmpty();
    }
}
