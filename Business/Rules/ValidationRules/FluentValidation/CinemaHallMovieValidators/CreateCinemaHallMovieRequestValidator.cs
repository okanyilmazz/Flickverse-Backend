using Business.Dtos.Requests.CinemaHallMovieRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CinemaHallMovieValidators;

public class CreateCinemaHallMovieRequestValidator : AbstractValidator<CreateCinemaHallMovieRequest>
{
    public CreateCinemaHallMovieRequestValidator()
    {
        RuleFor(chm => chm.CinemaHallId).NotEmpty();
        RuleFor(chm => chm.MovieId).NotEmpty();
    }
}
