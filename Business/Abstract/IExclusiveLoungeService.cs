using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface IExclusiveLoungeService
{
    Task<CreatedExclusiveLoungeResponse> AddAsync(CreateExclusiveLoungeRequest createExclusiveLoungeRequest);
    Task<UpdatedExclusiveLoungeResponse> UpdateAsync(UpdateExclusiveLoungeRequest updateExclusiveLoungeRequest);
    Task<DeletedExclusiveLoungeResponse> DeleteAsync(DeleteExclusiveLoungeRequest deleteExclusiveLoungeRequest);
    Task<IPaginate<GetExclusiveLoungeListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetExclusiveLoungeListResponse> GetByIdAsync(Guid id);
}
