namespace Business.Dtos.Requests.CinemaHallMovieRequests;

public class UpdateCinemaHallMovieRequest
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid CinemaHallId { get; set; }
}