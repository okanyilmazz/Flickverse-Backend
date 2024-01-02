namespace Business.Dtos.Responses.DeletedResponses;

public class DeletedCinemaHallResponse
{
    public Guid Id { get; set; }
    public Guid AddressId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
