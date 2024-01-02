namespace Business.Dtos.Responses.GetListResponses
{
    public class GetMovieImageListResponse
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public string ImagePath { get; set; }
    }
}