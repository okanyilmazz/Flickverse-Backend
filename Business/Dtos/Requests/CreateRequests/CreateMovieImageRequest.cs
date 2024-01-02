namespace Business.Dtos.Requests.CreateRequests;

public class CreateMovieImageRequest
{
    public Guid MovieId { get; set; }
    public string ImagePath { get; set; }
}