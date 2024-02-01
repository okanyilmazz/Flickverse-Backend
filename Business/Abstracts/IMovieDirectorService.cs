using Business.Dtos.Requests.MovieDirectorRequests;
using Business.Dtos.Responses.MovieDirectorResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IMovieDirectorService
{
    Task<CreatedMovieDirectorResponse> AddAsync(CreateMovieDirectorRequest createMovieDirectorRequest);
    Task<UpdatedMovieDirectorResponse> UpdateAsync(UpdateMovieDirectorRequest updateMovieDirectorRequest);
    Task<DeletedMovieDirectorResponse> DeleteAsync(DeleteMovieDirectorRequest deleteMovieDirectorRequest);
    Task<IPaginate<GetMovieDirectorListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetMovieDirectorListResponse> GetByIdAsync(Guid id);
}
