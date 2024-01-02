namespace Business.Dtos.Responses.CreatedResponses;

public class CreatedMovieImageResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public string ImagePath { get; set; }
}
