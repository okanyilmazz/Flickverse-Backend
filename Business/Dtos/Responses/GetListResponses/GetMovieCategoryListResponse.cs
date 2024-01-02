namespace Business.Dtos.Responses.GetListResponses
{
    public class GetMovieCategoryListResponse
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public Guid CategoryId { get; set; }
    }
}