namespace Business.Dtos.Responses.GetListResponses
{
    public class GetDirectorImageListResponse
    {
        public Guid Id { get; set; }
        public Guid DirectorId { get; set; }
        public string ImagePath { get; set; }
    }
}