namespace Business.Dtos.Requests.CreateRequests;

public class CreateMovieCastRequest
{
    public Guid MovieId { get; set; }
    public Guid CastId { get; set; }
}
