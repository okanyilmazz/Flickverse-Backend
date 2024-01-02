namespace Business.Dtos.Requests.UpdateRequests;

public class UpdateMovieCategoryRequest
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid CategoryId { get; set; }
}