namespace Business.Dtos.Requests.MovieCategoryRequests;

public class CreateMovieCategoryRequest
{
    public Guid MovieId { get; set; }
    public Guid CategoryId { get; set; }
}
