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

public class DirectorImageManager : IDirectorImageService
{
    IDirectorImageDal _directorImageDal;
    IMapper _mapper;

    public DirectorImageManager(IDirectorImageDal directorImageDal, IMapper mapper)
    {
        _directorImageDal = directorImageDal;
        _mapper = mapper;
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

    public async Task<IPaginate<GetDirectorImageListResponse>> GetListAsync()
    {
        var directorImageList = await _directorImageDal.GetListAsync();
        var mappedDirectorImageList = _mapper.Map<Paginate<GetDirectorImageListResponse>>(directorImageList);
        return mappedDirectorImageList;
    }

    public async Task<UpdatedDirectorImageResponse> UpdateAsync(UpdateDirectorImageRequest updateDirectorImageRequest)
    {
        DirectorImage directorImage = _mapper.Map<DirectorImage>(updateDirectorImageRequest);
        DirectorImage updatedDirectorImage = await _directorImageDal.UpdateAsync(directorImage);
        UpdatedDirectorImageResponse updatedDirectorImageResponse = _mapper.Map<UpdatedDirectorImageResponse>(updatedDirectorImage);
        return updatedDirectorImageResponse;
    }
}