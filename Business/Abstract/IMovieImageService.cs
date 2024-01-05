using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface IMovieImageService
{
    Task<CreatedMovieImageResponse> AddAsync(CreateMovieImageRequest createMovieImageRequest);
    Task<UpdatedMovieImageResponse> UpdateAsync(UpdateMovieImageRequest updateMovieImageRequest);
    Task<DeletedMovieImageResponse> DeleteAsync(DeleteMovieImageRequest deleteMovieImageRequest);
    Task<IPaginate<GetMovieImageListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetMovieImageListResponse> GetByIdAsync(Guid id);
}
