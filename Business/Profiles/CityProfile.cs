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

public class CityProfile : Profile
{
    public CityProfile()
    {
        CreateMap<City, CreateCityRequest>().ReverseMap();
        CreateMap<City, UpdateCityRequest>().ReverseMap();
        CreateMap<City, DeleteCityRequest>().ReverseMap();

        CreateMap<City, CreatedCityResponse>().ReverseMap();
        CreateMap<City, UpdatedCityResponse>().ReverseMap();
        CreateMap<City, DeletedCityResponse>().ReverseMap();

        CreateMap<IPaginate<City>, Paginate<GetCityListResponse>>().ReverseMap();
        CreateMap<City, GetCityListResponse>().ReverseMap();
    }
}
