using Business.Dtos.Requests.MovieImageRequests;
using Business.Dtos.Responses.MovieImageResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IMovieImageService
{
    Task<CreatedMovieImageResponse> AddAsync(CreateMovieImageRequest createMovieImageRequest);
    Task<UpdatedMovieImageResponse> UpdateAsync(UpdateMovieImageRequest updateMovieImageRequest);
    Task<DeletedMovieImageResponse> DeleteAsync(DeleteMovieImageRequest deleteMovieImageRequest);
    Task<IPaginate<GetMovieImageListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetMovieImageListResponse> GetByIdAsync(Guid id);
}
