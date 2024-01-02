
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

public class CastManager : ICastService
{
    ICastDal _castDal;
    IMapper _mapper;

    public CastManager(ICastDal castDal, IMapper mapper)
    {
        _castDal = castDal;
        _mapper = mapper;
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

    public async Task<IPaginate<GetCastListResponse>> GetListAsync()
    {
        var castList = await _castDal.GetListAsync();
        var mappedCastList = _mapper.Map<Paginate<GetCastListResponse>>(castList);
        return mappedCastList;
    }

    public async Task<UpdatedCastResponse> UpdateAsync(UpdateCastRequest updateCastRequest)
    {
        Cast cast = _mapper.Map<Cast>(updateCastRequest);
        Cast updatedCast = await _castDal.UpdateAsync(cast);
        UpdatedCastResponse updatedCastResponse = _mapper.Map<UpdatedCastResponse>(updatedCast);
        return updatedCastResponse;
    }
}
