namespace Business.Dtos.Responses.MovieCastResponses;

public class UpdatedMovieCastResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid CastId { get; set; }
}
