namespace Business.Dtos.Requests.DirectorImageRequests;

public class CreateDirectorImageRequest
{
    public Guid DirectorId { get; set; }
    public string ImagePath { get; set; }
}
