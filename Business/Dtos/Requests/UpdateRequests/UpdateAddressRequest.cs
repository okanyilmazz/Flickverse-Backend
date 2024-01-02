namespace Business.Dtos.Requests.UpdateRequests;

public class UpdateAddressRequest
{
    public Guid Id { get; set; }
    public Guid DistrictId { get; set; }
    public Guid CityId { get; set; }
    public Guid CountryId { get; set; }
    public string AddressDetail { get; set; }
}