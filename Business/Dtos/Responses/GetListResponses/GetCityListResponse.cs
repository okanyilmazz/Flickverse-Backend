namespace Business.Dtos.Responses.GetListResponses
{
    public class GetCityListResponse
    {
        public Guid Id { get; set; }
        public Guid CountryId { get; set; }
        public string Name { get; set; }
    }
}