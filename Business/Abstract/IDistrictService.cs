using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface IDistrictService
{
    Task<CreatedDistrictResponse> AddAsync(CreateDistrictRequest createDistrictRequest);
    Task<UpdatedDistrictResponse> UpdateAsync(UpdateDistrictRequest updateDistrictRequest);
    Task<DeletedDistrictResponse> DeleteAsync(DeleteDistrictRequest deleteDistrictRequest);
    Task<IPaginate<GetDistrictListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetDistrictListResponse> GetByIdAsync(Guid id);
}
