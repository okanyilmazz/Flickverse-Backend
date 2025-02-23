namespace Business.Dtos.Requests.CampaignRequests;

public class CreateCampaignRequest
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ImagePath { get; set; }
}