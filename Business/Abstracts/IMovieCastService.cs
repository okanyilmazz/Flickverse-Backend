using Business.Dtos.Requests.MovieCastRequests;
using Business.Dtos.Responses.MovieCastResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IMovieCastService
{
    Task<CreatedMovieCastResponse> AddAsync(CreateMovieCastRequest createMovieCastRequest);
    Task<UpdatedMovieCastResponse> UpdateAsync(UpdateMovieCastRequest updateMovieCastRequest);
    Task<DeletedMovieCastResponse> DeleteAsync(DeleteMovieCastRequest deleteMovieCastRequest);
    Task<IPaginate<GetMovieCastListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetMovieCastListResponse> GetByIdAsync(Guid id);
}
