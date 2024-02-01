namespace Business.Dtos.Responses.MovieDirectorResponses
{
    public class GetMovieDirectorListResponse
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public Guid DirectorId { get; set; }
    }
}