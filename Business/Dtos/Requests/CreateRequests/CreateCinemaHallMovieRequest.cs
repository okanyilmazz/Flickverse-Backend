namespace Business.Dtos.Requests.CreateRequests;

public class CreateCinemaHallMovieRequest
{
    public Guid MovieId { get; set; }
    public Guid CinemaHallId { get; set; }
}
