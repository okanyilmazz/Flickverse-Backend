using Business.Dtos.Requests.CastImageRequests;
using Business.Dtos.Responses.CastImageResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICastImageService
{
    Task<CreatedCastImageResponse> AddAsync(CreateCastImageRequest createCastImageRequest);
    Task<UpdatedCastImageResponse> UpdateAsync(UpdateCastImageRequest updateCastImageRequest);
    Task<DeletedCastImageResponse> DeleteAsync(DeleteCastImageRequest deleteCastImageRequest);
    Task<IPaginate<GetCastImageListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetCastImageListResponse> GetByIdAsync(Guid id);
}
