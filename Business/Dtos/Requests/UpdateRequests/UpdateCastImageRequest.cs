namespace Business.Dtos.Requests.UpdateRequests;

public class UpdateCastImageRequest
{
    public Guid Id { get; set; }
    public Guid CastId { get; set; }
    public string ImagePath { get; set; }
}