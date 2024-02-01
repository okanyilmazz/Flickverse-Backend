namespace Business.Dtos.Requests.MovieImageRequests;

public class CreateMovieImageRequest
{
    public Guid MovieId { get; set; }
    public string ImagePath { get; set; }
}