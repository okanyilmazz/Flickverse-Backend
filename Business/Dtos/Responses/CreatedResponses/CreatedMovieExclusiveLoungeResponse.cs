namespace Business.Dtos.Responses.CreatedResponses;

public class CreatedMovieExclusiveLoungeResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid ExclusiveLoungeId { get; set; }
}
