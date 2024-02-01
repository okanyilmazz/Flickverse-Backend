namespace Business.Dtos.Requests.DirectorImageRequests;

public class UpdateDirectorImageRequest
{
    public Guid Id { get; set; }
    public Guid DirectorId { get; set; }
    public string ImagePath { get; set; }
}
