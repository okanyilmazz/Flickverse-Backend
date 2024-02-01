using AutoMapper;
using Business.Dtos.Requests.MovieCastRequests;
using Business.Dtos.Responses.MovieCastResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class MovieCastProfile : Profile
{
    public MovieCastProfile()
    {
        CreateMap<MovieCast, CreateMovieCastRequest>().ReverseMap();
        CreateMap<MovieCast, UpdateMovieCastRequest>().ReverseMap();
        CreateMap<MovieCast, DeleteMovieCastRequest>().ReverseMap();

        CreateMap<MovieCast, CreatedMovieCastResponse>().ReverseMap();
        CreateMap<MovieCast, UpdatedMovieCastResponse>().ReverseMap();
        CreateMap<MovieCast, DeletedMovieCastResponse>().ReverseMap();

        CreateMap<IPaginate<MovieCast>, Paginate<GetMovieCastListResponse>>().ReverseMap();
        CreateMap<MovieCast, GetMovieCastListResponse>().ReverseMap();
    }
}
