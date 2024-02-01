using AutoMapper;
using Business.Dtos.Requests.CastRequests;
using Business.Dtos.Responses.CastResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

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
