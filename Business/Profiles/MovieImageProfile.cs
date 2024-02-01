using AutoMapper;
using Business.Dtos.Requests.MovieImageRequests;
using Business.Dtos.Responses.MovieImageResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class MovieImageProfile : Profile
{
    public MovieImageProfile()
    {
        CreateMap<MovieImage, CreateMovieImageRequest>().ReverseMap();
        CreateMap<MovieImage, UpdateMovieImageRequest>().ReverseMap();
        CreateMap<MovieImage, DeleteMovieImageRequest>().ReverseMap();

        CreateMap<MovieImage, CreatedMovieImageResponse>().ReverseMap();
        CreateMap<MovieImage, UpdatedMovieImageResponse>().ReverseMap();
        CreateMap<MovieImage, DeletedMovieImageResponse>().ReverseMap();

        CreateMap<IPaginate<MovieImage>, Paginate<GetMovieImageListResponse>>().ReverseMap();
        CreateMap<MovieImage, GetMovieImageListResponse>().ReverseMap();
    }
}
