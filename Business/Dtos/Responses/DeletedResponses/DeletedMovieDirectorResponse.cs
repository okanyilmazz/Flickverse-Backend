
namespace Business.Dtos.Responses.DeletedResponses;

public class DeletedMovieDirectorResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid DirectorId { get; set; }
}
