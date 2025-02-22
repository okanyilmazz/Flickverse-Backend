namespace Business.Dtos.Requests.CampaignRequests;

public class UpdateCampaignRequest
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
