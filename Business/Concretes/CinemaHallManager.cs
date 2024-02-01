using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CinemaHallRequests;
using Business.Dtos.Responses.CinemaHallResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CinemaHallManager : ICinemaHallService
{
    ICinemaHallDal _cinemaHallDal;
    IMapper _mapper;
    CinemaHallBusinessRules _cinemaHallBusinessRules;

    public CinemaHallManager(ICinemaHallDal cinemaHallDal, IMapper mapper, CinemaHallBusinessRules cinemaHallBusinessRules)
    {
        _cinemaHallDal = cinemaHallDal;
        _mapper = mapper;
        _cinemaHallBusinessRules = cinemaHallBusinessRules;
    }
    public async Task<CreatedCinemaHallResponse> AddAsync(CreateCinemaHallRequest createCinemaHallRequest)
    {
        CinemaHall cinemaHall = _mapper.Map<CinemaHall>(createCinemaHallRequest);
        CinemaHall addedCinemaHall = await _cinemaHallDal.AddAsync(cinemaHall);
        CreatedCinemaHallResponse createdCinemaHallResponse = _mapper.Map<CreatedCinemaHallResponse>(addedCinemaHall);
        return createdCinemaHallResponse;
    }

    public async Task<DeletedCinemaHallResponse> DeleteAsync(DeleteCinemaHallRequest deleteCinemaHallRequest)
    {
        await _cinemaHallBusinessRules.IsExistsCinemaHall(deleteCinemaHallRequest.Id);
        CinemaHall cinemaHall = await _cinemaHallDal.GetAsync(
            predicate: a => a.Id == deleteCinemaHallRequest.Id);
        CinemaHall deletedCinemaHall = await _cinemaHallDal.DeleteAsync(cinemaHall);
        DeletedCinemaHallResponse deletedCinemaHallResponse = _mapper.Map<DeletedCinemaHallResponse>(deletedCinemaHall);
        return deletedCinemaHallResponse;
    }

    public async Task<GetCinemaHallListResponse> GetByIdAsync(Guid id)
    {
        CinemaHall cinemaHall = await _cinemaHallDal.GetAsync(
            predicate: a => a.Id == id);
        GetCinemaHallListResponse getCinemaHallListResponse = _mapper.Map<GetCinemaHallListResponse>(cinemaHall);
        return getCinemaHallListResponse;
    }

    public async Task<IPaginate<GetCinemaHallListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var cinemaHallList = await _cinemaHallDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedCinemaHallList = _mapper.Map<Paginate<GetCinemaHallListResponse>>(cinemaHallList);
        return mappedCinemaHallList;
    }

    public async Task<UpdatedCinemaHallResponse> UpdateAsync(UpdateCinemaHallRequest updateCinemaHallRequest)
    {
        await _cinemaHallBusinessRules.IsExistsCinemaHall(updateCinemaHallRequest.Id);
        CinemaHall cinemaHall = _mapper.Map<CinemaHall>(updateCinemaHallRequest);
        CinemaHall updatedCinemaHall = await _cinemaHallDal.UpdateAsync(cinemaHall);
        UpdatedCinemaHallResponse updatedCinemaHallResponse = _mapper.Map<UpdatedCinemaHallResponse>(updatedCinemaHall);
        return updatedCinemaHallResponse;
    }
}
