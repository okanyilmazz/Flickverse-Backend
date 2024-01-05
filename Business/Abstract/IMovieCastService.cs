using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface IMovieCastService
{
    Task<CreatedMovieCastResponse> AddAsync(CreateMovieCastRequest createMovieCastRequest);
    Task<UpdatedMovieCastResponse> UpdateAsync(UpdateMovieCastRequest updateMovieCastRequest);
    Task<DeletedMovieCastResponse> DeleteAsync(DeleteMovieCastRequest deleteMovieCastRequest);
    Task<IPaginate<GetMovieCastListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetMovieCastListResponse> GetByIdAsync(Guid id);
}
