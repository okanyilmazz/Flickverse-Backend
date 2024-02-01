using Business.Dtos.Requests.CategoryRequests;
using Business.Dtos.Responses.CategoryResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICategoryService
{
    Task<CreatedCategoryResponse> AddAsync(CreateCategoryRequest createCategoryRequest);
    Task<UpdatedCategoryResponse> UpdateAsync(UpdateCategoryRequest updateCategoryRequest);
    Task<DeletedCategoryResponse> DeleteAsync(DeleteCategoryRequest deleteCategoryRequest);
    Task<IPaginate<GetCategoryListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetCategoryListResponse> GetByIdAsync(Guid id);
}
