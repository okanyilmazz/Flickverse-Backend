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

public class MovieCategoryProfile : Profile
{
    public MovieCategoryProfile()
    {
        CreateMap<MovieCategory, CreateMovieCategoryRequest>().ReverseMap();
        CreateMap<MovieCategory, UpdateMovieCategoryRequest>().ReverseMap();
        CreateMap<MovieCategory, DeleteMovieCategoryRequest>().ReverseMap();

        CreateMap<MovieCategory, CreatedMovieCategoryResponse>().ReverseMap();
        CreateMap<MovieCategory, UpdatedMovieCategoryResponse>().ReverseMap();
        CreateMap<MovieCategory, DeletedMovieCategoryResponse>().ReverseMap();

        CreateMap<IPaginate<MovieCategory>, Paginate<GetMovieCategoryListResponse>>().ReverseMap();
        CreateMap<MovieCategory, GetMovieCategoryListResponse>().ReverseMap();
    }
}