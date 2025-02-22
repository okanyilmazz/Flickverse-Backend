using Business.Dtos.Requests.CampaignRequests;
using Business.Dtos.Responses.CampaignResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICampaignService
{
    Task<CreatedCampaignResponse> AddAsync(CreateCampaignRequest createCampaignRequest);
    Task<UpdatedCampaignResponse> UpdateAsync(UpdateCampaignRequest updateCampaignRequest);
    Task<DeletedCampaignResponse> DeleteAsync(Guid id);
    Task<IPaginate<GetCampaignListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetCampaignListResponse> GetByIdAsync(Guid id);
}