namespace Business.Dtos.Requests.UpdateRequests;

public class UpdateMovieDirectorRequest
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid DirectorId { get; set; }
}