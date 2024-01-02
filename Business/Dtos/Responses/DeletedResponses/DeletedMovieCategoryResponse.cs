
namespace Business.Dtos.Responses.DeletedResponses;

public class DeletedMovieCategoryResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid CategoryId { get; set; }
}
