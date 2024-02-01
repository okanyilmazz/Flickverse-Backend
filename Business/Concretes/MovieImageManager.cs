using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.MovieImageRequests;
using Business.Dtos.Responses.MovieImageResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class MovieImageManager : IMovieImageService
{
    IMovieImageDal _movieImageDal;
    IMapper _mapper;
    MovieImageBusinessRules _movieImageBusinessRules;

    public MovieImageManager(IMovieImageDal movieImageDal, IMapper mapper, MovieImageBusinessRules movieImageBusinessRules)
    {
        _movieImageDal = movieImageDal;
        _mapper = mapper;
        _movieImageBusinessRules = movieImageBusinessRules;
    }
    public async Task<CreatedMovieImageResponse> AddAsync(CreateMovieImageRequest createMovieImageRequest)
    {
        MovieImage movieImage = _mapper.Map<MovieImage>(createMovieImageRequest);
        MovieImage addedMovieImage = await _movieImageDal.AddAsync(movieImage);
        CreatedMovieImageResponse createdMovieImageResponse = _mapper.Map<CreatedMovieImageResponse>(addedMovieImage);
        return createdMovieImageResponse;
    }

    public async Task<DeletedMovieImageResponse> DeleteAsync(DeleteMovieImageRequest deleteMovieImageRequest)
    {
        await _movieImageBusinessRules.IsExistsMovieImage(deleteMovieImageRequest.Id);
        MovieImage movieImage = await _movieImageDal.GetAsync(
            predicate: a => a.Id == deleteMovieImageRequest.Id);
        MovieImage deletedMovieImage = await _movieImageDal.DeleteAsync(movieImage);
        DeletedMovieImageResponse deletedMovieImageResponse = _mapper.Map<DeletedMovieImageResponse>(deletedMovieImage);
        return deletedMovieImageResponse;
    }

    public async Task<GetMovieImageListResponse> GetByIdAsync(Guid id)
    {
        MovieImage movieImage = await _movieImageDal.GetAsync(
            predicate: a => a.Id == id);
        GetMovieImageListResponse getMovieImageListResponse = _mapper.Map<GetMovieImageListResponse>(movieImage);
        return getMovieImageListResponse;
    }

    public async Task<IPaginate<GetMovieImageListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var movieImageList = await _movieImageDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedMovieImageList = _mapper.Map<Paginate<GetMovieImageListResponse>>(movieImageList);
        return mappedMovieImageList;
    }

    public async Task<UpdatedMovieImageResponse> UpdateAsync(UpdateMovieImageRequest updateMovieImageRequest)
    {
        await _movieImageBusinessRules.IsExistsMovieImage(updateMovieImageRequest.Id);
        MovieImage movieImage = _mapper.Map<MovieImage>(updateMovieImageRequest);
        MovieImage updatedMovieImage = await _movieImageDal.UpdateAsync(movieImage);
        UpdatedMovieImageResponse updatedMovieImageResponse = _mapper.Map<UpdatedMovieImageResponse>(updatedMovieImage);
        return updatedMovieImageResponse;
    }
}