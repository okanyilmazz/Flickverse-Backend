using AutoMapper;
using Business.Dtos.Requests.CampaignRequests;
using Business.Dtos.Responses.CampaignResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class CampaginProfile : Profile
{
    public CampaginProfile()
    {
        CreateMap<Campaign, CreateCampaignRequest>().ReverseMap();
        CreateMap<Campaign, UpdateCampaignRequest>().ReverseMap();

        CreateMap<Campaign, CreatedCampaignResponse>().ReverseMap();
        CreateMap<Campaign, UpdatedCampaignResponse>().ReverseMap();
        CreateMap<Campaign, DeletedCampaignResponse>().ReverseMap();

        CreateMap<IPaginate<Campaign>, Paginate<GetCampaignListResponse>>().ReverseMap();
        CreateMap<Campaign, GetCampaignListResponse>().ReverseMap();
    }
}
