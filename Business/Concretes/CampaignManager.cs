using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CampaignRequests;
using Business.Dtos.Responses.CampaignResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CampaignManager : ICampaignService
{
    ICampaignDal _campaignDal;
    IMapper _mapper;
    CampaignBusinessRules _campaignBusinessRules;
    public CampaignManager(ICampaignDal campaignDal, IMapper mapper, CampaignBusinessRules campaignBusinessRules)
    {
        _campaignDal = campaignDal;
        _mapper = mapper;
        _campaignBusinessRules = campaignBusinessRules;
    }

    public async Task<CreatedCampaignResponse> AddAsync(CreateCampaignRequest createCampaignRequest)
    {
        Campaign campaign = _mapper.Map<Campaign>(createCampaignRequest);
        Campaign createdCampaign = await _campaignDal.AddAsync(campaign);
        CreatedCampaignResponse createdCampaignResponse = _mapper.Map<CreatedCampaignResponse>(createdCampaign);
        return createdCampaignResponse;
    }

    public async Task<DeletedCampaignResponse> DeleteAsync(Guid id)
    {
        await _campaignBusinessRules.IsExistsCampaign(id);
        Campaign campaign = await _campaignDal.GetAsync(
            predicate: c => c.Id == id);
        Campaign deletedCampaign = await _campaignDal.DeleteAsync(campaign);
        DeletedCampaignResponse deletedCampaignResponse = _mapper.Map<DeletedCampaignResponse>(deletedCampaign);
        return deletedCampaignResponse;
    }

    public async Task<GetCampaignListResponse> GetByIdAsync(Guid id)
    {
        Campaign campaign = await _campaignDal.GetAsync(
            predicate: c => c.Id ==id);
        GetCampaignListResponse getCampaignListResponse = _mapper.Map<GetCampaignListResponse>(campaign);
        return getCampaignListResponse;
    }

    public async Task<IPaginate<GetCampaignListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var campaignList = await _campaignDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedCampaignList = _mapper.Map<Paginate<GetCampaignListResponse>>(campaignList);
        return mappedCampaignList;
    }

    public async Task<UpdatedCampaignResponse> UpdateAsync(UpdateCampaignRequest updateCampaignRequest)
    {
        await _campaignBusinessRules.IsExistsCampaign(updateCampaignRequest.Id);
        Campaign campaign = _mapper.Map<Campaign>(updateCampaignRequest);
        Campaign updatedCampaign = await _campaignDal.UpdateAsync(campaign);
        UpdatedCampaignResponse updatedCampaignResponse = _mapper.Map<UpdatedCampaignResponse>(updatedCampaign);
        return updatedCampaignResponse;
    }
}