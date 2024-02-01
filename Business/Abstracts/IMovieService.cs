using Business.Dtos.Requests.MovieRequests;
using Business.Dtos.Responses.MovieResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IMovieService
{
    Task<CreatedMovieResponse> AddAsync(CreateMovieRequest createMovieRequest);
    Task<UpdatedMovieResponse> UpdateAsync(UpdateMovieRequest updateMovieRequest);
    Task<DeletedMovieResponse> DeleteAsync(DeleteMovieRequest deleteMovieRequest);
    Task<IPaginate<GetMovieListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetMovieListResponse> GetByIdAsync(Guid id);
    Task<IPaginate<GetMovieListResponse>> GetUpComingMoviesAsync(PageRequest pageRequest);
    Task<IPaginate<GetMovieListResponse>> GetMoviesInVisionAsync(PageRequest pageRequest);
}