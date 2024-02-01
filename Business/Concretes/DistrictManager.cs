using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.DistrictRequests;
using Business.Dtos.Responses.DistrictResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class DistrictManager : IDistrictService
{
    IDistrictDal _districtDal;
    IMapper _mapper;
    DistrictBusinessRules _districtBusinessRules;
    public DistrictManager(IDistrictDal districtDal, IMapper mapper)
    {
        _districtDal = districtDal;
        _mapper = mapper;
    }
    public async Task<CreatedDistrictResponse> AddAsync(CreateDistrictRequest createDistrictRequest)
    {
        District district = _mapper.Map<District>(createDistrictRequest);
        District addedDistrict = await _districtDal.AddAsync(district);
        CreatedDistrictResponse createdDistrictResponse = _mapper.Map<CreatedDistrictResponse>(addedDistrict);
        return createdDistrictResponse;
    }

    public async Task<DeletedDistrictResponse> DeleteAsync(DeleteDistrictRequest deleteDistrictRequest)
    {
        await _districtBusinessRules.IsExistsDistrict(deleteDistrictRequest.Id);
        District district = await _districtDal.GetAsync(
            predicate: a => a.Id == deleteDistrictRequest.Id);
        District deletedDistrict = await _districtDal.DeleteAsync(district);
        DeletedDistrictResponse deletedDistrictResponse = _mapper.Map<DeletedDistrictResponse>(deletedDistrict);
        return deletedDistrictResponse;
    }

    public async Task<GetDistrictListResponse> GetByIdAsync(Guid id)
    {
        District district = await _districtDal.GetAsync(
            predicate: a => a.Id == id);
        GetDistrictListResponse getDistrictListResponse = _mapper.Map<GetDistrictListResponse>(district);
        return getDistrictListResponse;
    }

    public async Task<IPaginate<GetDistrictListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var districtList = await _districtDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedDistrictList = _mapper.Map<Paginate<GetDistrictListResponse>>(districtList);
        return mappedDistrictList;
    }

    public async Task<UpdatedDistrictResponse> UpdateAsync(UpdateDistrictRequest updateDistrictRequest)
    {
        await _districtBusinessRules.IsExistsDistrict(updateDistrictRequest.Id);
        District district = _mapper.Map<District>(updateDistrictRequest);
        District updatedDistrict = await _districtDal.UpdateAsync(district);
        UpdatedDistrictResponse updatedDistrictResponse = _mapper.Map<UpdatedDistrictResponse>(updatedDistrict);
        return updatedDistrictResponse;
    }
}