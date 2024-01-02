namespace Business.Dtos.Responses.GetListResponses
{
    public class GetMovieExclusiveLoungeListResponse
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public Guid ExclusiveLoungeId { get; set; }
    }
}