namespace Business.Dtos.Requests.CategoryRequests;

public class UpdateCategoryRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}