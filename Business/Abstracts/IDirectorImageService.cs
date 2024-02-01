using Business.Dtos.Requests.DirectorImageRequests;
using Business.Dtos.Responses.DirectorImageResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IDirectorImageService
{
    Task<CreatedDirectorImageResponse> AddAsync(CreateDirectorImageRequest createDirectorImageRequest);
    Task<UpdatedDirectorImageResponse> UpdateAsync(UpdateDirectorImageRequest updateDirectorImageRequest);
    Task<DeletedDirectorImageResponse> DeleteAsync(DeleteDirectorImageRequest deleteDirectorImageRequest);
    Task<IPaginate<GetDirectorImageListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetDirectorImageListResponse> GetByIdAsync(Guid id);
}
