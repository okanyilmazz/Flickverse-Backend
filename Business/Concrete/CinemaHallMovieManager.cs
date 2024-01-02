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

public class CinemaHallMovieManager : ICinemaHallMovieService
{
    ICinemaHallMovieDal _cinemaHallMovieDal;
    IMapper _mapper;

    public CinemaHallMovieManager(ICinemaHallMovieDal cinemaHallMovieDal, IMapper mapper)
    {
        _cinemaHallMovieDal = cinemaHallMovieDal;
        _mapper = mapper;
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

    public async Task<IPaginate<GetCinemaHallMovieListResponse>> GetListAsync()
    {
        var cinemaHallMovieList = await _cinemaHallMovieDal.GetListAsync();
        var mappedCinemaHallMovieList = _mapper.Map<Paginate<GetCinemaHallMovieListResponse>>(cinemaHallMovieList);
        return mappedCinemaHallMovieList;
    }

    public async Task<UpdatedCinemaHallMovieResponse> UpdateAsync(UpdateCinemaHallMovieRequest updateCinemaHallMovieRequest)
    {
        CinemaHallMovie cinemaHallMovie = _mapper.Map<CinemaHallMovie>(updateCinemaHallMovieRequest);
        CinemaHallMovie updatedCinemaHallMovie = await _cinemaHallMovieDal.UpdateAsync(cinemaHallMovie);
        UpdatedCinemaHallMovieResponse updatedCinemaHallMovieResponse = _mapper.Map<UpdatedCinemaHallMovieResponse>(updatedCinemaHallMovie);
        return updatedCinemaHallMovieResponse;
    }
}