using AutoMapper;
using Business.Dtos.Requests.CountryRequests;
using Business.Dtos.Responses.CountryResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class CountryProfile : Profile
{
    public CountryProfile()
    {
        CreateMap<Country, CreateCountryRequest>().ReverseMap();
        CreateMap<Country, UpdateCountryRequest>().ReverseMap();
        CreateMap<Country, DeleteCountryRequest>().ReverseMap();

        CreateMap<Country, CreatedCountryResponse>().ReverseMap();
        CreateMap<Country, UpdatedCountryResponse>().ReverseMap();
        CreateMap<Country, DeletedCountryResponse>().ReverseMap();

        CreateMap<IPaginate<Country>, Paginate<GetCountryListResponse>>().ReverseMap();
        CreateMap<Country, GetCountryListResponse>().ReverseMap();
    }
}