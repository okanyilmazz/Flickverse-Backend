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

public class CityManager : ICityService
{
    ICityDal _cityDal;
    IMapper _mapper;

    public CityManager(ICityDal cityDal, IMapper mapper)
    {
        _cityDal = cityDal;
        _mapper = mapper;
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

    public async Task<IPaginate<GetCityListResponse>> GetListAsync()
    {
        var cityList = await _cityDal.GetListAsync();
        var mappedCityList = _mapper.Map<Paginate<GetCityListResponse>>(cityList);
        return mappedCityList;
    }

    public async Task<UpdatedCityResponse> UpdateAsync(UpdateCityRequest updateCityRequest)
    {
        City city = _mapper.Map<City>(updateCityRequest);
        City updatedCity = await _cityDal.UpdateAsync(city);
        UpdatedCityResponse updatedCityResponse = _mapper.Map<UpdatedCityResponse>(updatedCity);
        return updatedCityResponse;
    }
}