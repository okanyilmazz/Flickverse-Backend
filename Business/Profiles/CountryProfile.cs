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