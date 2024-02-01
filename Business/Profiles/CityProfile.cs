using AutoMapper;
using Business.Dtos.Requests.CityRequests;
using Business.Dtos.Responses.CityResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

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
