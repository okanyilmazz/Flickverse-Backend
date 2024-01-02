namespace Business.Dtos.Requests.CreateRequests;

public class CreateMovieExclusiveLoungeRequest
{
    public Guid MovieId { get; set; }
    public Guid ExclusiveLoungeId { get; set; }
}
