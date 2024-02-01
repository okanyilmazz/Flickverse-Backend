namespace Business.Dtos.Requests.CinemaHallExclusiveLoungeRequests;

public class UpdateCinemaHallExclusiveLoungeRequest
{
    public Guid Id { get; set; }
    public Guid CinemaHallId { get; set; }
    public Guid ExclusiveLoungeId { get; set; }
}
