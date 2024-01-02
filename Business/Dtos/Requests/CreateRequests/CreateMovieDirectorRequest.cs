namespace Business.Dtos.Requests.CreateRequests;

public class CreateMovieDirectorRequest
{
    public Guid MovieId { get; set; }
    public Guid DirectorId { get; set; }
}
