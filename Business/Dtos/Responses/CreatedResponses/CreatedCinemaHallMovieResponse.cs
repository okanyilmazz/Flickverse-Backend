namespace Business.Dtos.Responses.CreatedResponses;

public class CreatedCinemaHallMovieResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid CinemaHallId { get; set; }
}
