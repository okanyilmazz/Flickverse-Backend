using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CategoryRequests;
using Business.Dtos.Responses.CategoryResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;
    IMapper _mapper;
    CategoryBusinessRules _categoryBusinessRules;

    public CategoryManager(ICategoryDal categoryDal, IMapper mapper, CategoryBusinessRules categoryBusinessRules)
    {
        _categoryDal = categoryDal;
        _mapper = mapper;
        _categoryBusinessRules = categoryBusinessRules;
    }
    public async Task<CreatedCategoryResponse> AddAsync(CreateCategoryRequest createCategoryRequest)
    {
        Category category = _mapper.Map<Category>(createCategoryRequest);
        Category addedCategory = await _categoryDal.AddAsync(category);
        CreatedCategoryResponse createdCategoryResponse = _mapper.Map<CreatedCategoryResponse>(addedCategory);
        return createdCategoryResponse;
    }

    public async Task<DeletedCategoryResponse> DeleteAsync(DeleteCategoryRequest deleteCategoryRequest)
    {
        await _categoryBusinessRules.IsExistsCategory(deleteCategoryRequest.Id);
        Category category = await _categoryDal.GetAsync(
            predicate: a => a.Id == deleteCategoryRequest.Id);
        Category deletedCategory = await _categoryDal.DeleteAsync(category);
        DeletedCategoryResponse deletedCategoryResponse = _mapper.Map<DeletedCategoryResponse>(deletedCategory);
        return deletedCategoryResponse;
    }

    public async Task<GetCategoryListResponse> GetByIdAsync(Guid id)
    {
        Category category = await _categoryDal.GetAsync(
            predicate: a => a.Id == id);
        GetCategoryListResponse getCategoryListResponse = _mapper.Map<GetCategoryListResponse>(category);
        return getCategoryListResponse;
    }

    public async Task<IPaginate<GetCategoryListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var categoryList = await _categoryDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedCategoryList = _mapper.Map<Paginate<GetCategoryListResponse>>(categoryList);
        return mappedCategoryList;
    }

    public async Task<UpdatedCategoryResponse> UpdateAsync(UpdateCategoryRequest updateCategoryRequest)
    {
        await _categoryBusinessRules.IsExistsCategory(updateCategoryRequest.Id);
        Category category = _mapper.Map<Category>(updateCategoryRequest);
        Category updatedCategory = await _categoryDal.UpdateAsync(category);
        UpdatedCategoryResponse updatedCategoryResponse = _mapper.Map<UpdatedCategoryResponse>(updatedCategory);
        return updatedCategoryResponse;
    }
}
