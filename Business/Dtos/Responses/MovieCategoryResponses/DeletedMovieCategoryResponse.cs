namespace Business.Dtos.Responses.MovieCategoryResponses;

public class DeletedMovieCategoryResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid CategoryId { get; set; }
}
