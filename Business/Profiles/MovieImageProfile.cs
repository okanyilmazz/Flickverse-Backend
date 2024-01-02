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
