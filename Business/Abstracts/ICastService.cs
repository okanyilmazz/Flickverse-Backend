using Business.Dtos.Requests.CastRequests;
using Business.Dtos.Responses.CastResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICastService
{
    Task<CreatedCastResponse> AddAsync(CreateCastRequest createCastRequest);
    Task<UpdatedCastResponse> UpdateAsync(UpdateCastRequest updateCastRequest);
    Task<DeletedCastResponse> DeleteAsync(DeleteCastRequest deleteCastRequest);
    Task<IPaginate<GetCastListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetCastListResponse> GetByIdAsync(Guid id);
}
