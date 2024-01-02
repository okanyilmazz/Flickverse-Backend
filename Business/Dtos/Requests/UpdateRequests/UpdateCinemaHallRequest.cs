namespace Business.Dtos.Requests.UpdateRequests;

public class UpdateCinemaHallRequest
{
    public Guid Id { get; set; }
    public Guid AddressId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}