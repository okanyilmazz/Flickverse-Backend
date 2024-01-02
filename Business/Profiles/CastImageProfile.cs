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