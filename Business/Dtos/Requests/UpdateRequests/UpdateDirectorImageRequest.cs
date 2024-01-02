namespace Business.Dtos.Requests.UpdateRequests;

public class UpdateDirectorImageRequest
{
    public Guid Id { get; set; }
    public Guid DirectorId { get; set; }
    public string ImagePath { get; set; }
}
