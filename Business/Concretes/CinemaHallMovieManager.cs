using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CinemaHallMovieRequests;
using Business.Dtos.Responses.CinemaHallMovieResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CinemaHallMovieManager : ICinemaHallMovieService
{
    ICinemaHallMovieDal _cinemaHallMovieDal;
    IMapper _mapper;
    CinemaHallMovieBusinessRules _cinemaHallMovieBusinessRules;

    public CinemaHallMovieManager(ICinemaHallMovieDal cinemaHallMovieDal, IMapper mapper, CinemaHallMovieBusinessRules cinemaHallMovieBusinessRules)
    {
        _cinemaHallMovieDal = cinemaHallMovieDal;
        _mapper = mapper;
        _cinemaHallMovieBusinessRules = cinemaHallMovieBusinessRules;
    }
    public async Task<CreatedCinemaHallMovieResponse> AddAsync(CreateCinemaHallMovieRequest createCinemaHallMovieRequest)
    {
        CinemaHallMovie cinemaHallMovie = _mapper.Map<CinemaHallMovie>(createCinemaHallMovieRequest);
        CinemaHallMovie addedCinemaHallMovie = await _cinemaHallMovieDal.AddAsync(cinemaHallMovie);
        CreatedCinemaHallMovieResponse createdCinemaHallMovieResponse = _mapper.Map<CreatedCinemaHallMovieResponse>(addedCinemaHallMovie);
        return createdCinemaHallMovieResponse;
    }

    public async Task<DeletedCinemaHallMovieResponse> DeleteAsync(DeleteCinemaHallMovieRequest deleteCinemaHallMovieRequest)
    {
        await _cinemaHallMovieBusinessRules.IsExistsCinemaHallMovie(deleteCinemaHallMovieRequest.Id);
        CinemaHallMovie cinemaHallMovie = await _cinemaHallMovieDal.GetAsync(
            predicate: a => a.Id == deleteCinemaHallMovieRequest.Id);
        CinemaHallMovie deletedCinemaHallMovie = await _cinemaHallMovieDal.DeleteAsync(cinemaHallMovie);
        DeletedCinemaHallMovieResponse deletedCinemaHallMovieResponse = _mapper.Map<DeletedCinemaHallMovieResponse>(deletedCinemaHallMovie);
        return deletedCinemaHallMovieResponse;
    }

    public async Task<GetCinemaHallMovieListResponse> GetByIdAsync(Guid id)
    {
        CinemaHallMovie cinemaHallMovie = await _cinemaHallMovieDal.GetAsync(
            predicate: a => a.Id == id);
        GetCinemaHallMovieListResponse getCinemaHallMovieListResponse = _mapper.Map<GetCinemaHallMovieListResponse>(cinemaHallMovie);
        return getCinemaHallMovieListResponse;
    }

    public async Task<IPaginate<GetCinemaHallMovieListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var cinemaHallMovieList = await _cinemaHallMovieDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedCinemaHallMovieList = _mapper.Map<Paginate<GetCinemaHallMovieListResponse>>(cinemaHallMovieList);
        return mappedCinemaHallMovieList;
    }

    public async Task<UpdatedCinemaHallMovieResponse> UpdateAsync(UpdateCinemaHallMovieRequest updateCinemaHallMovieRequest)
    {
        await _cinemaHallMovieBusinessRules.IsExistsCinemaHallMovie(updateCinemaHallMovieRequest.Id);
        CinemaHallMovie cinemaHallMovie = _mapper.Map<CinemaHallMovie>(updateCinemaHallMovieRequest);
        CinemaHallMovie updatedCinemaHallMovie = await _cinemaHallMovieDal.UpdateAsync(cinemaHallMovie);
        UpdatedCinemaHallMovieResponse updatedCinemaHallMovieResponse = _mapper.Map<UpdatedCinemaHallMovieResponse>(updatedCinemaHallMovie);
        return updatedCinemaHallMovieResponse;
    }
}