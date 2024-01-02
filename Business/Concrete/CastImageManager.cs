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

public class CastImageManager : ICastImageService
{
    ICastImageDal _castImageDal;
    IMapper _mapper;

    public CastImageManager(ICastImageDal castImageDal, IMapper mapper)
    {
        _castImageDal = castImageDal;
        _mapper = mapper;
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

    public async Task<IPaginate<GetCastImageListResponse>> GetListAsync()
    {
        var castImageList = await _castImageDal.GetListAsync();
        var mappedCastImageList = _mapper.Map<Paginate<GetCastImageListResponse>>(castImageList);
        return mappedCastImageList;
    }

    public async Task<UpdatedCastImageResponse> UpdateAsync(UpdateCastImageRequest updateCastImageRequest)
    {
        CastImage castImage = _mapper.Map<CastImage>(updateCastImageRequest);
        CastImage updatedCastImage = await _castImageDal.UpdateAsync(castImage);
        UpdatedCastImageResponse updatedCastImageResponse = _mapper.Map<UpdatedCastImageResponse>(updatedCastImage);
        return updatedCastImageResponse;
    }
}
