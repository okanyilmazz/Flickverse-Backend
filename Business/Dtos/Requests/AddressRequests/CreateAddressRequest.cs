namespace Business.Dtos.Requests.AddressRequests;

public class CreateAddressRequest
{
    public Guid DistrictId { get; set; }
    public Guid CityId { get; set; }
    public Guid CountryId { get; set; }
    public string AddressDetail { get; set; }
}
