﻿namespace Business.Dtos.Responses.CampaignResponses;

public class DeletedCampaignResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
