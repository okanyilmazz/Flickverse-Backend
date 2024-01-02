namespace Business.Dtos.Responses.CreatedResponses;

public class CreatedDirectorImageResponse
{
    public Guid Id { get; set; }
    public Guid DirectorId { get; set; }
    public string ImagePath { get; set; }
}
