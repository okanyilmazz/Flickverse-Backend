namespace Business.Dtos.Responses.CreatedResponses;

public class CreatedMovieCategoryResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid CategoryId { get; set; }
}
