namespace Business.Dtos.Requests.CreateRequests;

public class CreateMovieCategoryRequest
{
    public Guid MovieId { get; set; }
    public Guid CategoryId { get; set; }
}
