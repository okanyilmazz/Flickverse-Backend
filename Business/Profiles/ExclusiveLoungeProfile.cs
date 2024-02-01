using AutoMapper;
using Business.Dtos.Requests.ExclusiveLoungeRequests;
using Business.Dtos.Responses.ExclusiveLoungeResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class ExclusiveLoungeProfile : Profile
{
    public ExclusiveLoungeProfile()
    {
        CreateMap<ExclusiveLounge, CreateExclusiveLoungeRequest>().ReverseMap();
        CreateMap<ExclusiveLounge, UpdateExclusiveLoungeRequest>().ReverseMap();
        CreateMap<ExclusiveLounge, DeleteExclusiveLoungeRequest>().ReverseMap();

        CreateMap<ExclusiveLounge, CreatedExclusiveLoungeResponse>().ReverseMap();
        CreateMap<ExclusiveLounge, UpdatedExclusiveLoungeResponse>().ReverseMap();
        CreateMap<ExclusiveLounge, DeletedExclusiveLoungeResponse>().ReverseMap();

        CreateMap<IPaginate<ExclusiveLounge>, Paginate<GetExclusiveLoungeListResponse>>().ReverseMap();
        CreateMap<ExclusiveLounge, GetExclusiveLoungeListResponse>().ReverseMap();
    }
}
