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

public class MovieManager : IMovieService
{
    IMovieDal _movieDal;
    IMapper _mapper;
    MovieBusinessRules _movieBusinessRules;

    public MovieManager(IMovieDal movieDal, IMapper mapper, MovieBusinessRules movieBusinessRules)
    {
        _movieDal = movieDal;
        _mapper = mapper;
        _movieBusinessRules = movieBusinessRules;
    }
    public async Task<CreatedMovieResponse> AddAsync(CreateMovieRequest createMovieRequest)
    {
        Movie movie = _mapper.Map<Movie>(createMovieRequest);
        Movie addedMovie = await _movieDal.AddAsync(movie);
        CreatedMovieResponse createdMovieResponse = _mapper.Map<CreatedMovieResponse>(addedMovie);
        return createdMovieResponse;
    }

    public async Task<DeletedMovieResponse> DeleteAsync(DeleteMovieRequest deleteMovieRequest)
    {
        await _movieBusinessRules.IsExistsMovie(deleteMovieRequest.Id);
        Movie movie = await _movieDal.GetAsync(
            predicate: a => a.Id == deleteMovieRequest.Id);
        Movie deletedMovie = await _movieDal.DeleteAsync(movie);
        DeletedMovieResponse deletedMovieResponse = _mapper.Map<DeletedMovieResponse>(deletedMovie);
        return deletedMovieResponse;
    }

    public async Task<GetMovieListResponse> GetByIdAsync(Guid id)
    {
        Movie movie = await _movieDal.GetAsync(
            predicate: a => a.Id == id);
        GetMovieListResponse getMovieListResponse = _mapper.Map<GetMovieListResponse>(movie);
        return getMovieListResponse;
    }

    public async Task<IPaginate<GetMovieListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var movieList = await _movieDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedMovieList = _mapper.Map<Paginate<GetMovieListResponse>>(movieList);
        return mappedMovieList;
    }

    public async Task<UpdatedMovieResponse> UpdateAsync(UpdateMovieRequest updateMovieRequest)
    {
        await _movieBusinessRules.IsExistsMovie(updateMovieRequest.Id);
        Movie movie = _mapper.Map<Movie>(updateMovieRequest);
        Movie updatedMovie = await _movieDal.UpdateAsync(movie);
        UpdatedMovieResponse updatedMovieResponse = _mapper.Map<UpdatedMovieResponse>(updatedMovie);
        return updatedMovieResponse;
    }
}