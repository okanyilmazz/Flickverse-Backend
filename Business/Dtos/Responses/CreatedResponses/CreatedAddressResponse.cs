namespace Business.Dtos.Responses.CreatedResponses;

public class CreatedAddressResponse
{
    public Guid Id { get; set; }
    public Guid DistrictId { get; set; }
    public Guid CityId { get; set; }
    public Guid CountryId { get; set; }
    public string AddressDetail { get; set; }
}
