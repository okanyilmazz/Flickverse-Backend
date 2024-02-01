using Business.Dtos.Requests.MovieCategoryRequests;
using Business.Dtos.Responses.MovieCategoryResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IMovieCategoryService
{
    Task<CreatedMovieCategoryResponse> AddAsync(CreateMovieCategoryRequest createMovieCategoryRequest);
    Task<UpdatedMovieCategoryResponse> UpdateAsync(UpdateMovieCategoryRequest updateMovieCategoryRequest);
    Task<DeletedMovieCategoryResponse> DeleteAsync(DeleteMovieCategoryRequest deleteMovieCategoryRequest);
    Task<IPaginate<GetMovieCategoryListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetMovieCategoryListResponse> GetByIdAsync(Guid id);
}
