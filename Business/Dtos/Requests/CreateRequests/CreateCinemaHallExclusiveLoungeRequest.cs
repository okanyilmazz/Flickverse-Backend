namespace Business.Dtos.Requests.CreateRequests;

public class CreateCinemaHallExclusiveLoungeRequest
{
    public Guid CinemaHallId { get; set; }
    public Guid ExclusiveLoungeId { get; set; }
}
