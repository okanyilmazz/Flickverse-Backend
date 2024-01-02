namespace Business.Dtos.Responses.CreatedResponses;

public class CreatedMovieDirectorResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid DirectorId { get; set; }
}
