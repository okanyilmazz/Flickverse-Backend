using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.DirectorRequests;
using Business.Dtos.Responses.DirectorResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class DirectorManager : IDirectorService
{
    IDirectorDal _directorDal;
    IMapper _mapper;
    DirectorBusinessRules _directorBusinessRules;

    public DirectorManager(IDirectorDal directorDal, IMapper mapper, DirectorBusinessRules directorBusinessRules)
    {
        _directorDal = directorDal;
        _mapper = mapper;
        _directorBusinessRules = directorBusinessRules;
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
        await _directorBusinessRules.IsExistsDirector(deleteDirectorRequest.Id);
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

    public async Task<IPaginate<GetDirectorListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var directorList = await _directorDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedDirectorList = _mapper.Map<Paginate<GetDirectorListResponse>>(directorList);
        return mappedDirectorList;
    }

    public async Task<UpdatedDirectorResponse> UpdateAsync(UpdateDirectorRequest updateDirectorRequest)
    {
        await _directorBusinessRules.IsExistsDirector(updateDirectorRequest.Id);
        Director director = _mapper.Map<Director>(updateDirectorRequest);
        Director updatedDirector = await _directorDal.UpdateAsync(director);
        UpdatedDirectorResponse updatedDirectorResponse = _mapper.Map<UpdatedDirectorResponse>(updatedDirector);
        return updatedDirectorResponse;
    }
}