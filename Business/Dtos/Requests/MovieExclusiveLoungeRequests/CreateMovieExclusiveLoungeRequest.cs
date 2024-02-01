namespace Business.Dtos.Requests.MovieExclusiveLoungeRequests;

public class CreateMovieExclusiveLoungeRequest
{
    public Guid MovieId { get; set; }
    public Guid ExclusiveLoungeId { get; set; }
}
