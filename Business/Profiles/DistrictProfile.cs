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
