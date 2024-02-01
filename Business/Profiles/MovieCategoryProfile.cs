using AutoMapper;
using Business.Dtos.Requests.MovieCategoryRequests;
using Business.Dtos.Responses.MovieCategoryResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

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