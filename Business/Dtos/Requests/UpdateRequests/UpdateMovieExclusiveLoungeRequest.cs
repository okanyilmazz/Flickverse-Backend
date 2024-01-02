namespace Business.Dtos.Requests.UpdateRequests;

public class UpdateMovieExclusiveLoungeRequest
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid ExclusiveLoungeId { get; set; }
}