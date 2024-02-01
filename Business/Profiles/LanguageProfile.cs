using AutoMapper;
using Business.Dtos.Requests.LanguageRequests;
using Business.Dtos.Responses.LanguageResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class LanguageProfile : Profile
{
    public LanguageProfile()
    {
        CreateMap<Language, CreateLanguageRequest>().ReverseMap();
        CreateMap<Language, UpdateLanguageRequest>().ReverseMap();
        CreateMap<Language, DeleteLanguageRequest>().ReverseMap();

        CreateMap<Language, CreatedLanguageResponse>().ReverseMap();
        CreateMap<Language, UpdatedLanguageResponse>().ReverseMap();
        CreateMap<Language, DeletedLanguageResponse>().ReverseMap();

        CreateMap<IPaginate<Language>, Paginate<GetLanguageListResponse>>().ReverseMap();
        CreateMap<Language, GetLanguageListResponse>().ReverseMap();
    }
}
