using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface IMovieCategoryService
{
    Task<CreatedMovieCategoryResponse> AddAsync(CreateMovieCategoryRequest createMovieCategoryRequest);
    Task<UpdatedMovieCategoryResponse> UpdateAsync(UpdateMovieCategoryRequest updateMovieCategoryRequest);
    Task<DeletedMovieCategoryResponse> DeleteAsync(DeleteMovieCategoryRequest deleteMovieCategoryRequest);
    Task<IPaginate<GetMovieCategoryListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetMovieCategoryListResponse> GetByIdAsync(Guid id);
}
