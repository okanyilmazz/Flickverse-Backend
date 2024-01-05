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

public class MovieCastManager : IMovieCastService
{
    IMovieCastDal _movieCastDal;
    IMapper _mapper;
    MovieCastBusinessRules _movieCastBusinessRules;

    public MovieCastManager(IMovieCastDal movieCastDal, IMapper mapper, MovieCastBusinessRules movieCastBusinessRules)
    {
        _movieCastDal = movieCastDal;
        _mapper = mapper;
        _movieCastBusinessRules = movieCastBusinessRules;
    }

    public async Task<CreatedMovieCastResponse> AddAsync(CreateMovieCastRequest createMovieCastRequest)
    {
        MovieCast movieCast = _mapper.Map<MovieCast>(createMovieCastRequest);
        MovieCast addedMovieCast = await _movieCastDal.AddAsync(movieCast);
        CreatedMovieCastResponse createdMovieCastResponse = _mapper.Map<CreatedMovieCastResponse>(addedMovieCast);
        return createdMovieCastResponse;
    }

    public async Task<DeletedMovieCastResponse> DeleteAsync(DeleteMovieCastRequest deleteMovieCastRequest)
    {
        await _movieCastBusinessRules.IsExistsMovieCast(deleteMovieCastRequest.Id);
        MovieCast movieCast = await _movieCastDal.GetAsync(
           predicate: a => a.Id == deleteMovieCastRequest.Id);
        MovieCast deletedMovieCast = await _movieCastDal.DeleteAsync(movieCast);
        DeletedMovieCastResponse deletedMovieCastResponse = _mapper.Map<DeletedMovieCastResponse>(deletedMovieCast);
        return deletedMovieCastResponse;
    }

    public async Task<GetMovieCastListResponse> GetByIdAsync(Guid id)
    {
        MovieCast movieCast = await _movieCastDal.GetAsync(
            predicate: a => a.Id == id);
        GetMovieCastListResponse getMovieCastListResponse = _mapper.Map<GetMovieCastListResponse>(movieCast);
        return getMovieCastListResponse;
    }

    public async Task<IPaginate<GetMovieCastListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var movieCastList = await _movieCastDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedMovieCastList = _mapper.Map<Paginate<GetMovieCastListResponse>>(movieCastList);
        return mappedMovieCastList;
    }

    public async Task<UpdatedMovieCastResponse> UpdateAsync(UpdateMovieCastRequest updateMovieCastRequest)
    {
        await _movieCastBusinessRules.IsExistsMovieCast(updateMovieCastRequest.Id);
        MovieCast movieCast = _mapper.Map<MovieCast>(updateMovieCastRequest);
        MovieCast updatedMovieCast = await _movieCastDal.UpdateAsync(movieCast);
        UpdatedMovieCastResponse updatedMovieCastResponse = _mapper.Map<UpdatedMovieCastResponse>(updatedMovieCast);
        return updatedMovieCastResponse;
    }
}