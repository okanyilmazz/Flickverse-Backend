using AutoMapper;
using Business.Dtos.Requests.DistrictRequests;
using Business.Dtos.Responses.DistrictResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class DistrictProfile : Profile
{
    public DistrictProfile()
    {
        CreateMap<District, CreateDistrictRequest>().ReverseMap();
        CreateMap<District, UpdateDistrictRequest>().ReverseMap();
        CreateMap<District, DeleteDistrictRequest>().ReverseMap();

        CreateMap<District, CreatedDistrictResponse>().ReverseMap();
        CreateMap<District, UpdatedDistrictResponse>().ReverseMap();
        CreateMap<District, DeletedDistrictResponse>().ReverseMap();

        CreateMap<IPaginate<District>, Paginate<GetDistrictListResponse>>().ReverseMap();
        CreateMap<District, GetDistrictListResponse>().ReverseMap();
    }
}
