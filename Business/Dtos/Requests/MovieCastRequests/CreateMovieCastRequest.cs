namespace Business.Dtos.Requests.MovieCastRequests;

public class CreateMovieCastRequest
{
    public Guid MovieId { get; set; }
    public Guid CastId { get; set; }
}
