using Business.Dtos.Requests.UpdateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;

public class UpdateCinemaHallMovieRequestValidator:AbstractValidator<UpdateCinemaHallMovieRequest>
{
    public UpdateCinemaHallMovieRequestValidator()
    {
        RuleFor(chm => chm.CinemaHallId).NotEmpty();
        RuleFor(chm => chm.MovieId).NotEmpty();
    }
}
