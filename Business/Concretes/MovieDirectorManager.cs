﻿using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.MovieDirectorRequests;
using Business.Dtos.Responses.MovieDirectorResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class MovieDirectorManager : IMovieDirectorService
{
    IMovieDirectorDal _movieDirectorDal;
    IMapper _mapper;
    MovieDirectorBusinessRules _movieDirectorBusinessRules;

    public MovieDirectorManager(IMovieDirectorDal movieDirectorDal, IMapper mapper, MovieDirectorBusinessRules movieDirectorBusinessRules)
    {
        _movieDirectorDal = movieDirectorDal;
        _mapper = mapper;
        _movieDirectorBusinessRules = movieDirectorBusinessRules;
    }
    public async Task<CreatedMovieDirectorResponse> AddAsync(CreateMovieDirectorRequest createMovieDirectorRequest)
    {
        MovieDirector movieDirector = _mapper.Map<MovieDirector>(createMovieDirectorRequest);
        MovieDirector addedMovieDirector = await _movieDirectorDal.AddAsync(movieDirector);
        CreatedMovieDirectorResponse createdMovieDirectorResponse = _mapper.Map<CreatedMovieDirectorResponse>(addedMovieDirector);
        return createdMovieDirectorResponse;
    }

    public async Task<DeletedMovieDirectorResponse> DeleteAsync(DeleteMovieDirectorRequest deleteMovieDirectorRequest)
    {
        await _movieDirectorBusinessRules.IsExistsMovieDirector(deleteMovieDirectorRequest.Id);
        MovieDirector movieDirector = await _movieDirectorDal.GetAsync(
            predicate: a => a.Id == deleteMovieDirectorRequest.Id);
        MovieDirector deletedMovieDirector = await _movieDirectorDal.DeleteAsync(movieDirector);
        DeletedMovieDirectorResponse deletedMovieDirectorResponse = _mapper.Map<DeletedMovieDirectorResponse>(deletedMovieDirector);
        return deletedMovieDirectorResponse;
    }

    public async Task<GetMovieDirectorListResponse> GetByIdAsync(Guid id)
    {
        MovieDirector movieDirector = await _movieDirectorDal.GetAsync(
            predicate: a => a.Id == id);
        GetMovieDirectorListResponse getMovieDirectorListResponse = _mapper.Map<GetMovieDirectorListResponse>(movieDirector);
        return getMovieDirectorListResponse;
    }

    public async Task<IPaginate<GetMovieDirectorListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var movieDirectorList = await _movieDirectorDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedMovieDirectorList = _mapper.Map<Paginate<GetMovieDirectorListResponse>>(movieDirectorList);
        return mappedMovieDirectorList;
    }

    public async Task<UpdatedMovieDirectorResponse> UpdateAsync(UpdateMovieDirectorRequest updateMovieDirectorRequest)
    {
        await _movieDirectorBusinessRules.IsExistsMovieDirector(updateMovieDirectorRequest.Id);
        MovieDirector movieDirector = _mapper.Map<MovieDirector>(updateMovieDirectorRequest);
        MovieDirector updatedMovieDirector = await _movieDirectorDal.UpdateAsync(movieDirector);
        UpdatedMovieDirectorResponse updatedMovieDirectorResponse = _mapper.Map<UpdatedMovieDirectorResponse>(updatedMovieDirector);
        return updatedMovieDirectorResponse;
    }
}