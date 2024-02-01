using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CastImageRequests;
using Business.Dtos.Responses.CastImageResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CastImageManager : ICastImageService
{
    ICastImageDal _castImageDal;
    IMapper _mapper;
    CastImageBusinessRules _castImageBusinessRules;

    public CastImageManager(ICastImageDal castImageDal, IMapper mapper, CastImageBusinessRules castImageBusinessRules)
    {
        _castImageDal = castImageDal;
        _mapper = mapper;
        _castImageBusinessRules = castImageBusinessRules;
    }
    public async Task<CreatedCastImageResponse> AddAsync(CreateCastImageRequest createCastImageRequest)
    {
        CastImage castImage = _mapper.Map<CastImage>(createCastImageRequest);
        CastImage addedCastImage = await _castImageDal.AddAsync(castImage);
        CreatedCastImageResponse createdCastImageResponse = _mapper.Map<CreatedCastImageResponse>(addedCastImage);
        return createdCastImageResponse;
    }

    public async Task<DeletedCastImageResponse> DeleteAsync(DeleteCastImageRequest deleteCastImageRequest)
    {
        await _castImageBusinessRules.IsExistsCastImage(deleteCastImageRequest.Id);
        CastImage castImage = await _castImageDal.GetAsync(
            predicate: a => a.Id == deleteCastImageRequest.Id);
        CastImage deletedCastImage = await _castImageDal.DeleteAsync(castImage);
        DeletedCastImageResponse deletedCastImageResponse = _mapper.Map<DeletedCastImageResponse>(deletedCastImage);
        return deletedCastImageResponse;
    }

    public async Task<GetCastImageListResponse> GetByIdAsync(Guid id)
    {
        CastImage castImage = await _castImageDal.GetAsync(
            predicate: a => a.Id == id);
        GetCastImageListResponse getCastImageListResponse = _mapper.Map<GetCastImageListResponse>(castImage);
        return getCastImageListResponse;
    }

    public async Task<IPaginate<GetCastImageListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var castImageList = await _castImageDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedCastImageList = _mapper.Map<Paginate<GetCastImageListResponse>>(castImageList);
        return mappedCastImageList;
    }

    public async Task<UpdatedCastImageResponse> UpdateAsync(UpdateCastImageRequest updateCastImageRequest)
    {
        await _castImageBusinessRules.IsExistsCastImage(updateCastImageRequest.Id);
        CastImage castImage = _mapper.Map<CastImage>(updateCastImageRequest);
        CastImage updatedCastImage = await _castImageDal.UpdateAsync(castImage);
        UpdatedCastImageResponse updatedCastImageResponse = _mapper.Map<UpdatedCastImageResponse>(updatedCastImage);
        return updatedCastImageResponse;
    }
}
