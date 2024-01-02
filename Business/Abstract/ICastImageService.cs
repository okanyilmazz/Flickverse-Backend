using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface ICastImageService
{
    Task<CreatedCastImageResponse> AddAsync(CreateCastImageRequest createCastImageRequest);
    Task<UpdatedCastImageResponse> UpdateAsync(UpdateCastImageRequest updateCastImageRequest);
    Task<DeletedCastImageResponse> DeleteAsync(DeleteCastImageRequest deleteCastImageRequest);
    Task<IPaginate<GetCastImageListResponse>> GetListAsync();
    Task<GetCastImageListResponse> GetByIdAsync(Guid id);
}
