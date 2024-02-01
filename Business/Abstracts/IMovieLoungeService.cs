using Business.Dtos.Requests.MovieExclusiveLoungeRequests;
using Business.Dtos.Responses.MovieExclusiveLoungeResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IMovieExclusiveLoungeService
{
    Task<CreatedMovieExclusiveLoungeResponse> AddAsync(CreateMovieExclusiveLoungeRequest createMovieExclusiveLoungeRequest);
    Task<UpdatedMovieExclusiveLoungeResponse> UpdateAsync(UpdateMovieExclusiveLoungeRequest updateMovieExclusiveLoungeRequest);
    Task<DeletedMovieExclusiveLoungeResponse> DeleteAsync(DeleteMovieExclusiveLoungeRequest deleteMovieExclusiveLoungeRequest);
    Task<IPaginate<GetMovieExclusiveLoungeListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetMovieExclusiveLoungeListResponse> GetByIdAsync(Guid id);
}
