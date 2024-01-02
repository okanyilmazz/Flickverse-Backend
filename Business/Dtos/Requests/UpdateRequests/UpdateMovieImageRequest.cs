namespace Business.Dtos.Requests.UpdateRequests;

public class UpdateMovieImageRequest
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public string ImagePath { get; set; }
}