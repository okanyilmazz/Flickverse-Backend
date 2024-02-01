namespace Business.Dtos.Requests.MovieDirectorRequests;

public class CreateMovieDirectorRequest
{
    public Guid MovieId { get; set; }
    public Guid DirectorId { get; set; }
}
