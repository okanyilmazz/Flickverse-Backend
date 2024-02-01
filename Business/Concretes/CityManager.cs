using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CityRequests;
using Business.Dtos.Responses.CityResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CityManager : ICityService
{
    ICityDal _cityDal;
    IMapper _mapper;
    CityBusinessRules _cityBusinessRules;

    public CityManager(ICityDal cityDal, IMapper mapper, CityBusinessRules cityBusinessRules)
    {
        _cityDal = cityDal;
        _mapper = mapper;
        _cityBusinessRules = cityBusinessRules;
    }
    public async Task<CreatedCityResponse> AddAsync(CreateCityRequest createCityRequest)
    {
        City city = _mapper.Map<City>(createCityRequest);
        City addedCity = await _cityDal.AddAsync(city);
        CreatedCityResponse createdCityResponse = _mapper.Map<CreatedCityResponse>(addedCity);
        return createdCityResponse;
    }

    public async Task<DeletedCityResponse> DeleteAsync(DeleteCityRequest deleteCityRequest)
    {
        await _cityBusinessRules.IsExistsCity(deleteCityRequest.Id);
        City city = await _cityDal.GetAsync(
            predicate: a => a.Id == deleteCityRequest.Id);
        City deletedCity = await _cityDal.DeleteAsync(city);
        DeletedCityResponse deletedCityResponse = _mapper.Map<DeletedCityResponse>(deletedCity);
        return deletedCityResponse;
    }

    public async Task<GetCityListResponse> GetByIdAsync(Guid id)
    {
        City city = await _cityDal.GetAsync(
            predicate: a => a.Id == id);
        GetCityListResponse getCityListResponse = _mapper.Map<GetCityListResponse>(city);
        return getCityListResponse;
    }

    public async Task<IPaginate<GetCityListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var cityList = await _cityDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedCityList = _mapper.Map<Paginate<GetCityListResponse>>(cityList);
        return mappedCityList;
    }

    public async Task<UpdatedCityResponse> UpdateAsync(UpdateCityRequest updateCityRequest)
    {
        await _cityBusinessRules.IsExistsCity(updateCityRequest.Id);
        City city = _mapper.Map<City>(updateCityRequest);
        City updatedCity = await _cityDal.UpdateAsync(city);
        UpdatedCityResponse updatedCityResponse = _mapper.Map<UpdatedCityResponse>(updatedCity);
        return updatedCityResponse;
    }
}