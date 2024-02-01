using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.AddressRequests;
using Business.Dtos.Responses.AddressResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class AddressManager : IAddressService
{
    IAddressDal _addressDal;
    IMapper _mapper;
    AddressBusinessRules _addressBusinessRules;
    public AddressManager(IAddressDal addressDal, IMapper mapper, AddressBusinessRules addressBusinessRules)
    {
        _addressDal = addressDal;
        _mapper = mapper;
        _addressBusinessRules = addressBusinessRules;
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
        await _addressBusinessRules.IsExistsAddress(deleteAddressRequest.Id);
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

    public async Task<IPaginate<GetAddressListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var addressList = await _addressDal.GetListAsync(
            size: pageRequest.PageSize,
            index:pageRequest.PageIndex);
        var mappedAddressList = _mapper.Map<Paginate<GetAddressListResponse>>(addressList);
        return mappedAddressList;
    }

    public async Task<UpdatedAddressResponse> UpdateAsync(UpdateAddressRequest updateAddressRequest)
    {
        await _addressBusinessRules.IsExistsAddress(updateAddressRequest.Id);
        Address address = _mapper.Map<Address>(updateAddressRequest);
        Address updatedAddress = await _addressDal.UpdateAsync(address);
        UpdatedAddressResponse updatedAddressResponse = _mapper.Map<UpdatedAddressResponse>(updatedAddress);
        return updatedAddressResponse;
    }
}
