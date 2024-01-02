namespace Business.Dtos.Responses.GetListResponses
{
    public class GetCinemaHallListResponse
    {
        public Guid Id { get; set; }
        public Guid AddressId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}