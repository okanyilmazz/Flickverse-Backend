
using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CastRequests;
using Business.Dtos.Responses.CastResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CastManager : ICastService
{
    ICastDal _castDal;
    IMapper _mapper;
    CastBusinessRules _castBusinessRules;

    public CastManager(ICastDal castDal, IMapper mapper, CastBusinessRules castBusinessRules)
    {
        _castDal = castDal;
        _mapper = mapper;
        _castBusinessRules = castBusinessRules;
    }
    public async Task<CreatedCastResponse> AddAsync(CreateCastRequest createCastRequest)
    {
        Cast cast = _mapper.Map<Cast>(createCastRequest);
        Cast addedCast = await _castDal.AddAsync(cast);
        CreatedCastResponse createdCastResponse = _mapper.Map<CreatedCastResponse>(addedCast);
        return createdCastResponse;
    }

    public async Task<DeletedCastResponse> DeleteAsync(DeleteCastRequest deleteCastRequest)
    {
        await _castBusinessRules.IsExistsCast(deleteCastRequest.Id);
        Cast cast = await _castDal.GetAsync(
            predicate: a => a.Id == deleteCastRequest.Id);
        Cast deletedCast = await _castDal.DeleteAsync(cast);
        DeletedCastResponse deletedCastResponse = _mapper.Map<DeletedCastResponse>(deletedCast);
        return deletedCastResponse;
    }

    public async Task<GetCastListResponse> GetByIdAsync(Guid id)
    {
        Cast cast = await _castDal.GetAsync(
            predicate: a => a.Id == id);
        GetCastListResponse getCastListResponse = _mapper.Map<GetCastListResponse>(cast);
        return getCastListResponse;
    }

    public async Task<IPaginate<GetCastListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var castList = await _castDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedCastList = _mapper.Map<Paginate<GetCastListResponse>>(castList);
        return mappedCastList;
    }

    public async Task<UpdatedCastResponse> UpdateAsync(UpdateCastRequest updateCastRequest)
    {
        await _castBusinessRules.IsExistsCast(updateCastRequest.Id);
        Cast cast = _mapper.Map<Cast>(updateCastRequest);
        Cast updatedCast = await _castDal.UpdateAsync(cast);
        UpdatedCastResponse updatedCastResponse = _mapper.Map<UpdatedCastResponse>(updatedCast);
        return updatedCastResponse;
    }
}
