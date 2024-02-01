using Business.Dtos.Requests.CityRequests;
using Business.Dtos.Responses.CityResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICityService
{
    Task<CreatedCityResponse> AddAsync(CreateCityRequest createCityRequest);
    Task<UpdatedCityResponse> UpdateAsync(UpdateCityRequest updateCityRequest);
    Task<DeletedCityResponse> DeleteAsync(DeleteCityRequest deleteCityRequest);
    Task<IPaginate<GetCityListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetCityListResponse> GetByIdAsync(Guid id);
}
