namespace Business.Dtos.Requests.CastImageRequests;

public class CreateCastImageRequest
{
    public Guid CastId { get; set; }
    public string ImagePath { get; set; }
}
