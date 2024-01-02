namespace Business.Dtos.Requests.CreateRequests;

public class CreateAddressRequest
{
    public Guid DistrictId { get; set; }
    public Guid CityId { get; set; }
    public Guid CountryId { get; set; }
    public string AddressDetail { get; set; }
}
