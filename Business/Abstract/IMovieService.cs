using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface IMovieService
{
    Task<CreatedMovieResponse> AddAsync(CreateMovieRequest createMovieRequest);
    Task<UpdatedMovieResponse> UpdateAsync(UpdateMovieRequest updateMovieRequest);
    Task<DeletedMovieResponse> DeleteAsync(DeleteMovieRequest deleteMovieRequest);
    Task<IPaginate<GetMovieListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetMovieListResponse> GetByIdAsync(Guid id);
}
