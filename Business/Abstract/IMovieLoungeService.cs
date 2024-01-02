using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface IMovieExclusiveLoungeService
{
    Task<CreatedMovieExclusiveLoungeResponse> AddAsync(CreateMovieExclusiveLoungeRequest createMovieExclusiveLoungeRequest);
    Task<UpdatedMovieExclusiveLoungeResponse> UpdateAsync(UpdateMovieExclusiveLoungeRequest updateMovieExclusiveLoungeRequest);
    Task<DeletedMovieExclusiveLoungeResponse> DeleteAsync(DeleteMovieExclusiveLoungeRequest deleteMovieExclusiveLoungeRequest);
    Task<IPaginate<GetMovieExclusiveLoungeListResponse>> GetListAsync();
    Task<GetMovieExclusiveLoungeListResponse> GetByIdAsync(Guid id);
}
