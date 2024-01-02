namespace Business.Dtos.Requests.CreateRequests;

public class CreateDirectorImageRequest
{
    public Guid DirectorId { get; set; }
    public string ImagePath { get; set; }
}
