namespace Business.Dtos.Responses.CinemaHallMovieResponses;

public class CreatedCinemaHallMovieResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid CinemaHallId { get; set; }
}
