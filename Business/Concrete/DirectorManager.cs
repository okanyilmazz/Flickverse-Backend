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

public class DirectorManager : IDirectorService
{
    IDirectorDal _directorDal;
    IMapper _mapper;

    public DirectorManager(IDirectorDal directorDal, IMapper mapper)
    {
        _directorDal = directorDal;
        _mapper = mapper;
    }
    public async Task<CreatedDirectorResponse> AddAsync(CreateDirectorRequest createDirectorRequest)
    {
        Director director = _mapper.Map<Director>(createDirectorRequest);
        Director addedDirector = await _directorDal.AddAsync(director);
        CreatedDirectorResponse createdDirectorResponse = _mapper.Map<CreatedDirectorResponse>(addedDirector);
        return createdDirectorResponse;
    }

    public async Task<DeletedDirectorResponse> DeleteAsync(DeleteDirectorRequest deleteDirectorRequest)
    {
        Director director = await _directorDal.GetAsync(
            predicate: a => a.Id == deleteDirectorRequest.Id);
        Director deletedDirector = await _directorDal.DeleteAsync(director);
        DeletedDirectorResponse deletedDirectorResponse = _mapper.Map<DeletedDirectorResponse>(deletedDirector);
        return deletedDirectorResponse;
    }

    public async Task<GetDirectorListResponse> GetByIdAsync(Guid id)
    {
        Director director = await _directorDal.GetAsync(
            predicate: a => a.Id == id);
        GetDirectorListResponse getDirectorListResponse = _mapper.Map<GetDirectorListResponse>(director);
        return getDirectorListResponse;
    }

    public async Task<IPaginate<GetDirectorListResponse>> GetListAsync()
    {
        var directorList = await _directorDal.GetListAsync();
        var mappedDirectorList = _mapper.Map<Paginate<GetDirectorListResponse>>(directorList);
        return mappedDirectorList;
    }

    public async Task<UpdatedDirectorResponse> UpdateAsync(UpdateDirectorRequest updateDirectorRequest)
    {
        Director director = _mapper.Map<Director>(updateDirectorRequest);
        Director updatedDirector = await _directorDal.UpdateAsync(director);
        UpdatedDirectorResponse updatedDirectorResponse = _mapper.Map<UpdatedDirectorResponse>(updatedDirector);
        return updatedDirectorResponse;
    }
}