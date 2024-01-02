namespace Business.Dtos.Requests.UpdateRequests;

public class UpdateExclusiveLoungeRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}