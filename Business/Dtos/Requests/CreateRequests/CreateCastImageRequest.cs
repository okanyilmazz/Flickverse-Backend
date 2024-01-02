namespace Business.Dtos.Requests.CreateRequests;

public class CreateCastImageRequest
{
    public Guid CastId { get; set; }
    public string ImagePath { get; set; }
}
