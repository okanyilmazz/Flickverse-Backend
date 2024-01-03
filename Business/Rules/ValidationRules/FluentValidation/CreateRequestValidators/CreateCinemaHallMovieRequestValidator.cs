using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateCinemaHallMovieRequestValidator : AbstractValidator<CreateCinemaHallMovieRequest>
{
    public CreateCinemaHallMovieRequestValidator()
    {
        RuleFor(chm => chm.CinemaHallId).NotEmpty();
        RuleFor(chm => chm.MovieId).NotEmpty();
    }
}
