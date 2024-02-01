namespace Business.Dtos.Requests.MovieImageRequests;

public class UpdateMovieImageRequest
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public string ImagePath { get; set; }
}