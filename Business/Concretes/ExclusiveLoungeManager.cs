using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ExclusiveLoungeRequests;
using Business.Dtos.Responses.ExclusiveLoungeResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class ExclusiveLoungeManager : IExclusiveLoungeService
{
    IExclusiveLoungeDal _exclusiveLoungeDal;
    IMapper _mapper;
    ExclusiveLoungeBusinessRules _exclusiveLoungeBusinessRules;

    public ExclusiveLoungeManager(IExclusiveLoungeDal exclusiveLoungeDal, IMapper mapper, ExclusiveLoungeBusinessRules exclusiveLoungeBusinessRules)
    {
        _exclusiveLoungeDal = exclusiveLoungeDal;
        _mapper = mapper;
        _exclusiveLoungeBusinessRules = exclusiveLoungeBusinessRules;
    }
    public async Task<CreatedExclusiveLoungeResponse> AddAsync(CreateExclusiveLoungeRequest createExclusiveLoungeRequest)
    {
        ExclusiveLounge exclusiveLounge = _mapper.Map<ExclusiveLounge>(createExclusiveLoungeRequest);
        ExclusiveLounge addedExclusiveLounge = await _exclusiveLoungeDal.AddAsync(exclusiveLounge);
        CreatedExclusiveLoungeResponse createdExclusiveLoungeResponse = _mapper.Map<CreatedExclusiveLoungeResponse>(addedExclusiveLounge);
        return createdExclusiveLoungeResponse;
    }

    public async Task<DeletedExclusiveLoungeResponse> DeleteAsync(DeleteExclusiveLoungeRequest deleteExclusiveLoungeRequest)
    {
        await _exclusiveLoungeBusinessRules.IsExistsExclusiveLounge(deleteExclusiveLoungeRequest.Id);
        ExclusiveLounge exclusiveLounge = await _exclusiveLoungeDal.GetAsync(
            predicate: a => a.Id == deleteExclusiveLoungeRequest.Id);
        ExclusiveLounge deletedExclusiveLounge = await _exclusiveLoungeDal.DeleteAsync(exclusiveLounge);
        DeletedExclusiveLoungeResponse deletedExclusiveLoungeResponse = _mapper.Map<DeletedExclusiveLoungeResponse>(deletedExclusiveLounge);
        return deletedExclusiveLoungeResponse;
    }

    public async Task<GetExclusiveLoungeListResponse> GetByIdAsync(Guid id)
    {
        ExclusiveLounge exclusiveLounge = await _exclusiveLoungeDal.GetAsync(
            predicate: a => a.Id == id);
        GetExclusiveLoungeListResponse getExclusiveLoungeListResponse = _mapper.Map<GetExclusiveLoungeListResponse>(exclusiveLounge);
        return getExclusiveLoungeListResponse;
    }

    public async Task<IPaginate<GetExclusiveLoungeListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var exclusiveLoungeList = await _exclusiveLoungeDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedExclusiveLoungeList = _mapper.Map<Paginate<GetExclusiveLoungeListResponse>>(exclusiveLoungeList);
        return mappedExclusiveLoungeList;
    }

    public async Task<UpdatedExclusiveLoungeResponse> UpdateAsync(UpdateExclusiveLoungeRequest updateExclusiveLoungeRequest)
    {
        await _exclusiveLoungeBusinessRules.IsExistsExclusiveLounge(updateExclusiveLoungeRequest.Id);
        ExclusiveLounge exclusiveLounge = _mapper.Map<ExclusiveLounge>(updateExclusiveLoungeRequest);
        ExclusiveLounge updatedExclusiveLounge = await _exclusiveLoungeDal.UpdateAsync(exclusiveLounge);
        UpdatedExclusiveLoungeResponse updatedExclusiveLoungeResponse = _mapper.Map<UpdatedExclusiveLoungeResponse>(updatedExclusiveLounge);
        return updatedExclusiveLoungeResponse;
    }
}