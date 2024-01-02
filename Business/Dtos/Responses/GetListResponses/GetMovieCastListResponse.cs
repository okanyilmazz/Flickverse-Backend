namespace Business.Dtos.Responses.GetListResponses
{
    public class GetMovieCastListResponse
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public Guid CastId { get; set; }
    }
}