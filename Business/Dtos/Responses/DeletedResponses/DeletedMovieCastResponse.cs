
namespace Business.Dtos.Responses.DeletedResponses;

public class DeletedMovieCastResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid CastId { get; set; }
}
