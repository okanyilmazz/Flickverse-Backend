using AutoMapper;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;
using Entities.Concrete;

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
