namespace Business.Dtos.Responses.MovieCategoryResponses;

public class UpdatedMovieCategoryResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid CategoryId { get; set; }
}
