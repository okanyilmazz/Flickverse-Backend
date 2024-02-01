namespace Business.Dtos.Requests.MovieExclusiveLoungeRequests;

public class UpdateMovieExclusiveLoungeRequest
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid ExclusiveLoungeId { get; set; }
}