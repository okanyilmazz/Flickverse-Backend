namespace Business.Dtos.Responses.UpdatedResponses;

public class UpdatedDirectorImageResponse
{
    public Guid Id { get; set; }
    public Guid DirectorId { get; set; }
    public string ImagePath { get; set; }
}
