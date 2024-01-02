using AutoMapper;
using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concrete;

namespace Business.Concrete;

public class AddressManager : IAddressService
{
    IAddressDal _addressDal;
    IMapper _mapper;

    public AddressManager(IAddressDal addressDal, IMapper mapper)
    {
        _addressDal = addressDal;
        _mapper = mapper;
    }

    public async Task<CreatedAddressResponse> AddAsync(CreateAddressRequest createAddressRequest)
    {
        Address address = _mapper.Map<Address>(createAddressRequest);
        Address addedAddress = await _addressDal.AddAsync(address);
        CreatedAddressResponse createdAddressResponse = _mapper.Map<CreatedAddressResponse>(addedAddress);
        return createdAddressResponse;
    }

    public async Task<DeletedAddressResponse> DeleteAsync(DeleteAddressRequest deleteAddressRequest)
    {
        Address address = await _addressDal.GetAsync(
            predicate: a => a.Id == deleteAddressRequest.Id);
        Address deletedAddress = await _addressDal.DeleteAsync(address);
        DeletedAddressResponse deletedAddressResponse = _mapper.Map<DeletedAddressResponse>(deletedAddress);
        return deletedAddressResponse;
    }

    public async Task<GetAddressListResponse> GetByIdAsync(Guid id)
    {
        Address address = await _addressDal.GetAsync(
            predicate: a => a.Id == id);
        GetAddressListResponse getAddressListResponse = _mapper.Map<GetAddressListResponse>(address);
        return getAddressListResponse;
    }

    public async Task<IPaginate<GetAddressListResponse>> GetListAsync()
    {
        var addressList = await _addressDal.GetListAsync();
        var mappedAddressList = _mapper.Map<Paginate<GetAddressListResponse>>(addressList);
        return mappedAddressList;
    }

    public async Task<UpdatedAddressResponse> UpdateAsync(UpdateAddressRequest updateAddressRequest)
    {
        Address address = _mapper.Map<Address>(updateAddressRequest);
        Address updatedAddress = await _addressDal.UpdateAsync(address);
        UpdatedAddressResponse updatedAddressResponse = _mapper.Map<UpdatedAddressResponse>(updatedAddress);
        return updatedAddressResponse;
    }
}
