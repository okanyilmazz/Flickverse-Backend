namespace Business.Dtos.Responses.DeletedResponses;

public class DeletedCinemaHallMovieResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid CinemaHallId { get; set; }
}
