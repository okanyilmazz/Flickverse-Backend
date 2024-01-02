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

public class CountryManager : ICountryService
{
    ICountryDal _countryDal;
    IMapper _mapper;

    public CountryManager(ICountryDal countryDal, IMapper mapper)
    {
        _countryDal = countryDal;
        _mapper = mapper;
    }
    public async Task<CreatedCountryResponse> AddAsync(CreateCountryRequest createCountryRequest)
    {
        Country country = _mapper.Map<Country>(createCountryRequest);
        Country addedCountry = await _countryDal.AddAsync(country);
        CreatedCountryResponse createdCountryResponse = _mapper.Map<CreatedCountryResponse>(addedCountry);
        return createdCountryResponse;
    }

    public async Task<DeletedCountryResponse> DeleteAsync(DeleteCountryRequest deleteCountryRequest)
    {
        Country country = await _countryDal.GetAsync(
            predicate: a => a.Id == deleteCountryRequest.Id);
        Country deletedCountry = await _countryDal.DeleteAsync(country);
        DeletedCountryResponse deletedCountryResponse = _mapper.Map<DeletedCountryResponse>(deletedCountry);
        return deletedCountryResponse;
    }

    public async Task<GetCountryListResponse> GetByIdAsync(Guid id)
    {
        Country country = await _countryDal.GetAsync(
            predicate: a => a.Id == id);
        GetCountryListResponse getCountryListResponse = _mapper.Map<GetCountryListResponse>(country);
        return getCountryListResponse;
    }

    public async Task<IPaginate<GetCountryListResponse>> GetListAsync()
    {
        var countryList = await _countryDal.GetListAsync();
        var mappedCountryList = _mapper.Map<Paginate<GetCountryListResponse>>(countryList);
        return mappedCountryList;
    }

    public async Task<UpdatedCountryResponse> UpdateAsync(UpdateCountryRequest updateCountryRequest)
    {
        Country country = _mapper.Map<Country>(updateCountryRequest);
        Country updatedCountry = await _countryDal.UpdateAsync(country);
        UpdatedCountryResponse updatedCountryResponse = _mapper.Map<UpdatedCountryResponse>(updatedCountry);
        return updatedCountryResponse;
    }
}