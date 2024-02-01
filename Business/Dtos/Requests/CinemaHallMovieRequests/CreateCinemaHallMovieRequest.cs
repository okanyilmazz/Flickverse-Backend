namespace Business.Dtos.Requests.CinemaHallMovieRequests;

public class CreateCinemaHallMovieRequest
{
    public Guid MovieId { get; set; }
    public Guid CinemaHallId { get; set; }
}
