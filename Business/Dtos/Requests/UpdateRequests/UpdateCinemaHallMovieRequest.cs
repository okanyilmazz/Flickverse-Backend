namespace Business.Dtos.Requests.UpdateRequests;

public class UpdateCinemaHallMovieRequest
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid CinemaHallId { get; set; }
}