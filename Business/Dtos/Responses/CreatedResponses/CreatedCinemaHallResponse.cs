namespace Business.Dtos.Responses.CreatedResponses;

public class CreatedCinemaHallResponse
{
    public Guid Id { get; set; }
    public Guid AddressId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
