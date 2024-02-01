using Business.Dtos.Requests.AddressRequests;
using Business.Dtos.Responses.AddressResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IAddressService
{
    Task<CreatedAddressResponse> AddAsync(CreateAddressRequest createAddressRequest);
    Task<UpdatedAddressResponse> UpdateAsync(UpdateAddressRequest updateAddressRequest);
    Task<DeletedAddressResponse> DeleteAsync(DeleteAddressRequest deleteAddressRequest);
    Task<IPaginate<GetAddressListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetAddressListResponse> GetByIdAsync(Guid id);
}