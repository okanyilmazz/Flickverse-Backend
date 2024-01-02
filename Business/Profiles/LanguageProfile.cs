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
