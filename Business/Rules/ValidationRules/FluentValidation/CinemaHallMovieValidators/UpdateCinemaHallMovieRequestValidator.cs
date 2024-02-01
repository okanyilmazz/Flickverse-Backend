using Business.Dtos.Requests.CinemaHallMovieRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CinemaHallMovieValidators;

public class UpdateCinemaHallMovieRequestValidator : AbstractValidator<UpdateCinemaHallMovieRequest>
{
    public UpdateCinemaHallMovieRequestValidator()
    {
        RuleFor(chm => chm.CinemaHallId).NotEmpty();
        RuleFor(chm => chm.MovieId).NotEmpty();
    }
}
