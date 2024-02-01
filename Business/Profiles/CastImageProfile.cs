using AutoMapper;
using Business.Dtos.Requests.CastImageRequests;
using Business.Dtos.Responses.CastImageResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class CastImageProfile : Profile
{
    public CastImageProfile()
    {
        CreateMap<CastImage, CreateCastImageRequest>().ReverseMap();
        CreateMap<CastImage, UpdateCastImageRequest>().ReverseMap();
        CreateMap<CastImage, DeleteCastImageRequest>().ReverseMap();

        CreateMap<CastImage, CreatedCastImageResponse>().ReverseMap();
        CreateMap<CastImage, UpdatedCastImageResponse>().ReverseMap();
        CreateMap<CastImage, DeletedCastImageResponse>().ReverseMap();

        CreateMap<IPaginate<CastImage>, Paginate<GetCastImageListResponse>>().ReverseMap();
        CreateMap<CastImage, GetCastImageListResponse>().ReverseMap();
    }
}