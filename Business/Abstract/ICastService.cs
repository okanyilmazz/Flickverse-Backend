using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface ICastService
{
    Task<CreatedCastResponse> AddAsync(CreateCastRequest createCastRequest);
    Task<UpdatedCastResponse> UpdateAsync(UpdateCastRequest updateCastRequest);
    Task<DeletedCastResponse> DeleteAsync(DeleteCastRequest deleteCastRequest);
    Task<IPaginate<GetCastListResponse>> GetListAsync();
    Task<GetCastListResponse> GetByIdAsync(Guid id);
}
