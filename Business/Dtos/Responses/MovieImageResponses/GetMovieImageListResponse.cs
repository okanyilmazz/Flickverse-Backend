namespace Business.Dtos.Responses.MovieImageResponses
{
    public class GetMovieImageListResponse
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public string ImagePath { get; set; }
    }
}