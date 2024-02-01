using AutoMapper;
using Business.Dtos.Requests.MovieDirectorRequests;
using Business.Dtos.Responses.MovieDirectorResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class MovieDirectorProfile : Profile
{
    public MovieDirectorProfile()
    {
        CreateMap<MovieDirector, CreateMovieDirectorRequest>().ReverseMap();
        CreateMap<MovieDirector, UpdateMovieDirectorRequest>().ReverseMap();
        CreateMap<MovieDirector, DeleteMovieDirectorRequest>().ReverseMap();

        CreateMap<MovieDirector, CreatedMovieDirectorResponse>().ReverseMap();
        CreateMap<MovieDirector, UpdatedMovieDirectorResponse>().ReverseMap();
        CreateMap<MovieDirector, DeletedMovieDirectorResponse>().ReverseMap();

        CreateMap<IPaginate<MovieDirector>, Paginate<GetMovieDirectorListResponse>>().ReverseMap();
        CreateMap<MovieDirector, GetMovieDirectorListResponse>().ReverseMap();
    }
}
