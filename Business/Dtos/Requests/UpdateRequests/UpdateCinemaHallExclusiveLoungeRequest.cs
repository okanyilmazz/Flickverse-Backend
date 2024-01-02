namespace Business.Dtos.Requests.UpdateRequests;

public class UpdateCinemaHallExclusiveLoungeRequest
{
    public Guid Id { get; set; }
    public Guid CinemaHallId { get; set; }
    public Guid ExclusiveLoungeId { get; set; }
}
