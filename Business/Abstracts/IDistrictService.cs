using Business.Dtos.Requests.DistrictRequests;
using Business.Dtos.Responses.DistrictResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IDistrictService
{
    Task<CreatedDistrictResponse> AddAsync(CreateDistrictRequest createDistrictRequest);
    Task<UpdatedDistrictResponse> UpdateAsync(UpdateDistrictRequest updateDistrictRequest);
    Task<DeletedDistrictResponse> DeleteAsync(DeleteDistrictRequest deleteDistrictRequest);
    Task<IPaginate<GetDistrictListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetDistrictListResponse> GetByIdAsync(Guid id);
}
