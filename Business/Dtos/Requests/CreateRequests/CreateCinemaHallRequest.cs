namespace Business.Dtos.Requests.CreateRequests;

public class CreateCinemaHallRequest
{
    public Guid AddressId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
