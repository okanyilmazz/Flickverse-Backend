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

public class CastProfile : Profile
{
    public CastProfile()
    {
        CreateMap<Cast, CreateCastRequest>().ReverseMap();
        CreateMap<Cast, UpdateCastRequest>().ReverseMap();
        CreateMap<Cast, DeleteCastRequest>().ReverseMap();

        CreateMap<Cast, CreatedCastResponse>().ReverseMap();
        CreateMap<Cast, UpdatedCastResponse>().ReverseMap();
        CreateMap<Cast, DeletedCastResponse>().ReverseMap();

        CreateMap<IPaginate<Cast>, Paginate<GetCastListResponse>>().ReverseMap();
        CreateMap<Cast, GetCastListResponse>().ReverseMap();
    }
}
