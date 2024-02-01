namespace Business.Dtos.Requests.ExclusiveLoungeRequests;

public class UpdateExclusiveLoungeRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}