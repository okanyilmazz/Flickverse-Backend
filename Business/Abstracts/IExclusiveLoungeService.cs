using Business.Dtos.Requests.ExclusiveLoungeRequests;
using Business.Dtos.Responses.ExclusiveLoungeResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IExclusiveLoungeService
{
    Task<CreatedExclusiveLoungeResponse> AddAsync(CreateExclusiveLoungeRequest createExclusiveLoungeRequest);
    Task<UpdatedExclusiveLoungeResponse> UpdateAsync(UpdateExclusiveLoungeRequest updateExclusiveLoungeRequest);
    Task<DeletedExclusiveLoungeResponse> DeleteAsync(DeleteExclusiveLoungeRequest deleteExclusiveLoungeRequest);
    Task<IPaginate<GetExclusiveLoungeListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetExclusiveLoungeListResponse> GetByIdAsync(Guid id);
}
