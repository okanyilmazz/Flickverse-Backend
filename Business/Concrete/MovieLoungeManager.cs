using AutoMapper;
using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concrete;

namespace Business.Concrete;

public class MovieExclusiveLoungeManager : IMovieExclusiveLoungeService
{
    IMovieExclusiveLoungeDal _movieExclusiveLoungeDal;
    IMapper _mapper;

    public MovieExclusiveLoungeManager(IMovieExclusiveLoungeDal movieExclusiveLoungeDal, IMapper mapper)
    {
        _movieExclusiveLoungeDal = movieExclusiveLoungeDal;
        _mapper = mapper;
    }
    public async Task<CreatedMovieExclusiveLoungeResponse> AddAsync(CreateMovieExclusiveLoungeRequest createMovieExclusiveLoungeRequest)
    {
        MovieExclusiveLounge movieExclusiveLounge = _mapper.Map<MovieExclusiveLounge>(createMovieExclusiveLoungeRequest);
        MovieExclusiveLounge addedMovieExclusiveLounge = await _movieExclusiveLoungeDal.AddAsync(movieExclusiveLounge);
        CreatedMovieExclusiveLoungeResponse createdMovieExclusiveLoungeResponse = _mapper.Map<CreatedMovieExclusiveLoungeResponse>(addedMovieExclusiveLounge);
        return createdMovieExclusiveLoungeResponse;
    }

    public async Task<DeletedMovieExclusiveLoungeResponse> DeleteAsync(DeleteMovieExclusiveLoungeRequest deleteMovieExclusiveLoungeRequest)
    {
        MovieExclusiveLounge movieExclusiveLounge = await _movieExclusiveLoungeDal.GetAsync(
            predicate: a => a.Id == deleteMovieExclusiveLoungeRequest.Id);
        MovieExclusiveLounge deletedMovieExclusiveLounge = await _movieExclusiveLoungeDal.DeleteAsync(movieExclusiveLounge);
        DeletedMovieExclusiveLoungeResponse deletedMovieExclusiveLoungeResponse = _mapper.Map<DeletedMovieExclusiveLoungeResponse>(deletedMovieExclusiveLounge);
        return deletedMovieExclusiveLoungeResponse;
    }

    public async Task<GetMovieExclusiveLoungeListResponse> GetByIdAsync(Guid id)
    {
        MovieExclusiveLounge movieExclusiveLounge = await _movieExclusiveLoungeDal.GetAsync(
            predicate: a => a.Id == id);
        GetMovieExclusiveLoungeListResponse getMovieExclusiveLoungeListResponse = _mapper.Map<GetMovieExclusiveLoungeListResponse>(movieExclusiveLounge);
        return getMovieExclusiveLoungeListResponse;
    }

    public async Task<IPaginate<GetMovieExclusiveLoungeListResponse>> GetListAsync()
    {
        var movieExclusiveLoungeList = await _movieExclusiveLoungeDal.GetListAsync();
        var mappedMovieExclusiveLoungeList = _mapper.Map<Paginate<GetMovieExclusiveLoungeListResponse>>(movieExclusiveLoungeList);
        return mappedMovieExclusiveLoungeList;
    }

    public async Task<UpdatedMovieExclusiveLoungeResponse> UpdateAsync(UpdateMovieExclusiveLoungeRequest updateMovieExclusiveLoungeRequest)
    {
        MovieExclusiveLounge movieExclusiveLounge = _mapper.Map<MovieExclusiveLounge>(updateMovieExclusiveLoungeRequest);
        MovieExclusiveLounge updatedMovieExclusiveLounge = await _movieExclusiveLoungeDal.UpdateAsync(movieExclusiveLounge);
        UpdatedMovieExclusiveLoungeResponse updatedMovieExclusiveLoungeResponse = _mapper.Map<UpdatedMovieExclusiveLoungeResponse>(updatedMovieExclusiveLounge);
        return updatedMovieExclusiveLoungeResponse;
    }
}
