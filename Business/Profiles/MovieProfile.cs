using AutoMapper;
using Business.Dtos.Requests.MovieRequests;
using Business.Dtos.Responses.MovieResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class MovieProfile : Profile
{
    public MovieProfile()
    {
        CreateMap<Movie, CreateMovieRequest>().ReverseMap();
        CreateMap<Movie, UpdateMovieRequest>().ReverseMap();
        CreateMap<Movie, DeleteMovieRequest>().ReverseMap();

        CreateMap<Movie, CreatedMovieResponse>().ReverseMap();
        CreateMap<Movie, UpdatedMovieResponse>().ReverseMap();
        CreateMap<Movie, DeletedMovieResponse>().ReverseMap();

        CreateMap<IPaginate<Movie>, Paginate<GetMovieListResponse>>().ReverseMap();
        CreateMap<Movie, GetMovieListResponse>()
            .ForMember(dest => dest.ImagePath,
            opt => opt.MapFrom(src => src.MovieImages
            .Select(eq => eq.ImagePath).FirstOrDefault())).ReverseMap();
    }
}
