namespace Business.Dtos.Requests.MovieCastRequests;

public class UpdateMovieCastRequest
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid CastId { get; set; }
}