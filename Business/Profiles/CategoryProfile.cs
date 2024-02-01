using AutoMapper;
using Business.Dtos.Requests.CategoryRequests;
using Business.Dtos.Responses.CategoryResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CreateCategoryRequest>().ReverseMap();
        CreateMap<Category, UpdateCategoryRequest>().ReverseMap();
        CreateMap<Category, DeleteCategoryRequest>().ReverseMap();

        CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
        CreateMap<Category, UpdatedCategoryResponse>().ReverseMap();
        CreateMap<Category, DeletedCategoryResponse>().ReverseMap();

        CreateMap<IPaginate<Category>, Paginate<GetCategoryListResponse>>().ReverseMap();
        CreateMap<Category, GetCategoryListResponse>().ReverseMap();
    }
}