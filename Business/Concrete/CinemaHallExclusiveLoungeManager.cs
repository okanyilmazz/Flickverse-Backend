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

public class CinemaHallExclusiveLoungeManager : ICinemaHallExclusiveLoungeService
{
    ICinemaHallExclusiveLoungeDal _cinemaHallDal;
    IMapper _mapper;
    CinemaHallExclusiveLoungeBusinessRules _cinemaHallExclusiveLoungeBusinessRules;

    public CinemaHallExclusiveLoungeManager(ICinemaHallExclusiveLoungeDal cinemaHallDal, IMapper mapper, CinemaHallExclusiveLoungeBusinessRules cinemaHallExclusiveLoungeBusinessRules)
    {
        _cinemaHallDal = cinemaHallDal;
        _mapper = mapper;
        _cinemaHallExclusiveLoungeBusinessRules = cinemaHallExclusiveLoungeBusinessRules;
    }
    public async Task<CreatedCinemaHallExclusiveLoungeResponse> AddAsync(CreateCinemaHallExclusiveLoungeRequest createCinemaHallExclusiveLoungeRequest)
    {
        CinemaHallExclusiveLounge cinemaHall = _mapper.Map<CinemaHallExclusiveLounge>(createCinemaHallExclusiveLoungeRequest);
        CinemaHallExclusiveLounge addedCinemaHallExclusiveLounge = await _cinemaHallDal.AddAsync(cinemaHall);
        CreatedCinemaHallExclusiveLoungeResponse createdCinemaHallExclusiveLoungeResponse = _mapper.Map<CreatedCinemaHallExclusiveLoungeResponse>(addedCinemaHallExclusiveLounge);
        return createdCinemaHallExclusiveLoungeResponse;
    }

    public async Task<DeletedCinemaHallExclusiveLoungeResponse> DeleteAsync(DeleteCinemaHallExclusiveLoungeRequest deleteCinemaHallExclusiveLoungeRequest)
    {
        await _cinemaHallExclusiveLoungeBusinessRules.IsExistsCinemaHallExclusiveLounge(deleteCinemaHallExclusiveLoungeRequest.Id);
        CinemaHallExclusiveLounge cinemaHall = await _cinemaHallDal.GetAsync(
            predicate: a => a.Id == deleteCinemaHallExclusiveLoungeRequest.Id);
        CinemaHallExclusiveLounge deletedCinemaHallExclusiveLounge = await _cinemaHallDal.DeleteAsync(cinemaHall);
        DeletedCinemaHallExclusiveLoungeResponse deletedCinemaHallExclusiveLoungeResponse = _mapper.Map<DeletedCinemaHallExclusiveLoungeResponse>(deletedCinemaHallExclusiveLounge);
        return deletedCinemaHallExclusiveLoungeResponse;
    }

    public async Task<GetCinemaHallExclusiveLoungeListResponse> GetByIdAsync(Guid id)
    {
        CinemaHallExclusiveLounge cinemaHall = await _cinemaHallDal.GetAsync(
            predicate: a => a.Id == id);
        GetCinemaHallExclusiveLoungeListResponse getCinemaHallExclusiveLoungeListResponse = _mapper.Map<GetCinemaHallExclusiveLoungeListResponse>(cinemaHall);
        return getCinemaHallExclusiveLoungeListResponse;
    }

    public async Task<IPaginate<GetCinemaHallExclusiveLoungeListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var cinemaHallList = await _cinemaHallDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedCinemaHallExclusiveLoungeList = _mapper.Map<Paginate<GetCinemaHallExclusiveLoungeListResponse>>(cinemaHallList);
        return mappedCinemaHallExclusiveLoungeList;
    }

    public async Task<UpdatedCinemaHallExclusiveLoungeResponse> UpdateAsync(UpdateCinemaHallExclusiveLoungeRequest updateCinemaHallExclusiveLoungeRequest)
    {
        await _cinemaHallExclusiveLoungeBusinessRules.IsExistsCinemaHallExclusiveLounge(updateCinemaHallExclusiveLoungeRequest.Id);
        CinemaHallExclusiveLounge cinemaHall = _mapper.Map<CinemaHallExclusiveLounge>(updateCinemaHallExclusiveLoungeRequest);
        CinemaHallExclusiveLounge updatedCinemaHallExclusiveLounge = await _cinemaHallDal.UpdateAsync(cinemaHall);
        UpdatedCinemaHallExclusiveLoungeResponse updatedCinemaHallExclusiveLoungeResponse = _mapper.Map<UpdatedCinemaHallExclusiveLoungeResponse>(updatedCinemaHallExclusiveLounge);
        return updatedCinemaHallExclusiveLoungeResponse;
    }
}