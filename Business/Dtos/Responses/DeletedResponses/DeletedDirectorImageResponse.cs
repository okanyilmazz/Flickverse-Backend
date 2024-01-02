
namespace Business.Dtos.Responses.DeletedResponses;

public class DeletedDirectorImageResponse
{
    public Guid Id { get; set; }
    public Guid DirectorId { get; set; }
    public string ImagePath { get; set; }
}
