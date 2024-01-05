using AutoMapper;
using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concrete;

namespace Business.Concrete;

public class MovieCategoryManager : IMovieCategoryService
{
    IMovieCategoryDal _movieCategoryDal;
    IMapper _mapper;
    MovieCategoryBusinessRules _movieCategoryBusinessRules;

    public MovieCategoryManager(IMovieCategoryDal movieCategoryDal, IMapper mapper, MovieCategoryBusinessRules movieCategoryBusinessRules)
    {
        _movieCategoryDal = movieCategoryDal;
        _mapper = mapper;
        _movieCategoryBusinessRules = movieCategoryBusinessRules;
    }
    public async Task<CreatedMovieCategoryResponse> AddAsync(CreateMovieCategoryRequest createMovieCategoryRequest)
    {
        MovieCategory movieCategory = _mapper.Map<MovieCategory>(createMovieCategoryRequest);
        MovieCategory addedMovieCategory = await _movieCategoryDal.AddAsync(movieCategory);
        CreatedMovieCategoryResponse createdMovieCategoryResponse = _mapper.Map<CreatedMovieCategoryResponse>(addedMovieCategory);
        return createdMovieCategoryResponse;
    }

    public async Task<DeletedMovieCategoryResponse> DeleteAsync(DeleteMovieCategoryRequest deleteMovieCategoryRequest)
    {
        await _movieCategoryBusinessRules.IsExistsMovieCategory(deleteMovieCategoryRequest.Id);
        MovieCategory movieCategory = await _movieCategoryDal.GetAsync(
            predicate: a => a.Id == deleteMovieCategoryRequest.Id);
        MovieCategory deletedMovieCategory = await _movieCategoryDal.DeleteAsync(movieCategory);
        DeletedMovieCategoryResponse deletedMovieCategoryResponse = _mapper.Map<DeletedMovieCategoryResponse>(deletedMovieCategory);
        return deletedMovieCategoryResponse;
    }

    public async Task<GetMovieCategoryListResponse> GetByIdAsync(Guid id)
    {
        MovieCategory movieCategory = await _movieCategoryDal.GetAsync(
            predicate: a => a.Id == id);
        GetMovieCategoryListResponse getMovieCategoryListResponse = _mapper.Map<GetMovieCategoryListResponse>(movieCategory);
        return getMovieCategoryListResponse;
    }

    public async Task<IPaginate<GetMovieCategoryListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var movieCategoryList = await _movieCategoryDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedMovieCategoryList = _mapper.Map<Paginate<GetMovieCategoryListResponse>>(movieCategoryList);
        return mappedMovieCategoryList;
    }

    public async Task<UpdatedMovieCategoryResponse> UpdateAsync(UpdateMovieCategoryRequest updateMovieCategoryRequest)
    {
        await _movieCategoryBusinessRules.IsExistsMovieCategory(updateMovieCategoryRequest.Id);
        MovieCategory movieCategory = _mapper.Map<MovieCategory>(updateMovieCategoryRequest);
        MovieCategory updatedMovieCategory = await _movieCategoryDal.UpdateAsync(movieCategory);
        UpdatedMovieCategoryResponse updatedMovieCategoryResponse = _mapper.Map<UpdatedMovieCategoryResponse>(updatedMovieCategory);
        return updatedMovieCategoryResponse;
    }
}