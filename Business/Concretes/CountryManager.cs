using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CountryRequests;
using Business.Dtos.Responses.CountryResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CountryManager : ICountryService
{
    ICountryDal _countryDal;
    IMapper _mapper;
    CountryBusinessRules _countryBusinessRules;

    public CountryManager(ICountryDal countryDal, IMapper mapper, CountryBusinessRules countryBusinessRules)
    {
        _countryDal = countryDal;
        _mapper = mapper;
        _countryBusinessRules = countryBusinessRules;
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
        await _countryBusinessRules.IsExistsCountry(deleteCountryRequest.Id);
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

    public async Task<IPaginate<GetCountryListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var countryList = await _countryDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedCountryList = _mapper.Map<Paginate<GetCountryListResponse>>(countryList);
        return mappedCountryList;
    }

    public async Task<UpdatedCountryResponse> UpdateAsync(UpdateCountryRequest updateCountryRequest)
    {
        await _countryBusinessRules.IsExistsCountry(updateCountryRequest.Id);
        Country country = _mapper.Map<Country>(updateCountryRequest);
        Country updatedCountry = await _countryDal.UpdateAsync(country);
        UpdatedCountryResponse updatedCountryResponse = _mapper.Map<UpdatedCountryResponse>(updatedCountry);
        return updatedCountryResponse;
    }
}