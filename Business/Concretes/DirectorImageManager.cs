using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.DirectorImageRequests;
using Business.Dtos.Responses.DirectorImageResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class DirectorImageManager : IDirectorImageService
{
    IDirectorImageDal _directorImageDal;
    IMapper _mapper;
    DirectorImageBusinessRules _directorImageBusinessRules;

    public DirectorImageManager(IDirectorImageDal directorImageDal, IMapper mapper, DirectorImageBusinessRules directorImageBusinessRules)
    {
        _directorImageDal = directorImageDal;
        _mapper = mapper;
        _directorImageBusinessRules = directorImageBusinessRules;
    }
    public async Task<CreatedDirectorImageResponse> AddAsync(CreateDirectorImageRequest createDirectorImageRequest)
    {
        DirectorImage directorImage = _mapper.Map<DirectorImage>(createDirectorImageRequest);
        DirectorImage addedDirectorImage = await _directorImageDal.AddAsync(directorImage);
        CreatedDirectorImageResponse createdDirectorImageResponse = _mapper.Map<CreatedDirectorImageResponse>(addedDirectorImage);
        return createdDirectorImageResponse;
    }

    public async Task<DeletedDirectorImageResponse> DeleteAsync(DeleteDirectorImageRequest deleteDirectorImageRequest)
    {
        await _directorImageBusinessRules.IsExistsDirectorImage(deleteDirectorImageRequest.Id);
        DirectorImage directorImage = await _directorImageDal.GetAsync(
            predicate: a => a.Id == deleteDirectorImageRequest.Id);
        DirectorImage deletedDirectorImage = await _directorImageDal.DeleteAsync(directorImage);
        DeletedDirectorImageResponse deletedDirectorImageResponse = _mapper.Map<DeletedDirectorImageResponse>(deletedDirectorImage);
        return deletedDirectorImageResponse;
    }

    public async Task<GetDirectorImageListResponse> GetByIdAsync(Guid id)
    {
        DirectorImage directorImage = await _directorImageDal.GetAsync(
            predicate: a => a.Id == id);
        GetDirectorImageListResponse getDirectorImageListResponse = _mapper.Map<GetDirectorImageListResponse>(directorImage);
        return getDirectorImageListResponse;
    }

    public async Task<IPaginate<GetDirectorImageListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var directorImageList = await _directorImageDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedDirectorImageList = _mapper.Map<Paginate<GetDirectorImageListResponse>>(directorImageList);
        return mappedDirectorImageList;
    }

    public async Task<UpdatedDirectorImageResponse> UpdateAsync(UpdateDirectorImageRequest updateDirectorImageRequest)
    {
        await _directorImageBusinessRules.IsExistsDirectorImage(updateDirectorImageRequest.Id);
        DirectorImage directorImage = _mapper.Map<DirectorImage>(updateDirectorImageRequest);
        DirectorImage updatedDirectorImage = await _directorImageDal.UpdateAsync(directorImage);
        UpdatedDirectorImageResponse updatedDirectorImageResponse = _mapper.Map<UpdatedDirectorImageResponse>(updatedDirectorImage);
        return updatedDirectorImageResponse;
    }
}