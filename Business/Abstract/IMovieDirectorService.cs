using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface IMovieDirectorService
{
    Task<CreatedMovieDirectorResponse> AddAsync(CreateMovieDirectorRequest createMovieDirectorRequest);
    Task<UpdatedMovieDirectorResponse> UpdateAsync(UpdateMovieDirectorRequest updateMovieDirectorRequest);
    Task<DeletedMovieDirectorResponse> DeleteAsync(DeleteMovieDirectorRequest deleteMovieDirectorRequest);
    Task<IPaginate<GetMovieDirectorListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetMovieDirectorListResponse> GetByIdAsync(Guid id);
}
