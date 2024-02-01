namespace Business.Dtos.Responses.MovieCastResponses;

public class CreatedMovieCastResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid CastId { get; set; }
}
