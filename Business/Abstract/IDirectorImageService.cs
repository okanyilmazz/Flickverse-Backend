using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract
{
    public interface IDirectorImageService
    {
        Task<CreatedDirectorImageResponse> AddAsync(CreateDirectorImageRequest createDirectorImageRequest);
        Task<UpdatedDirectorImageResponse> UpdateAsync(UpdateDirectorImageRequest updateDirectorImageRequest);
        Task<DeletedDirectorImageResponse> DeleteAsync(DeleteDirectorImageRequest deleteDirectorImageRequest);
        Task<IPaginate<GetDirectorImageListResponse>> GetListAsync();
        Task<GetDirectorImageListResponse> GetByIdAsync(Guid id);
    }
}
