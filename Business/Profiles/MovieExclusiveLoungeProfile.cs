using AutoMapper;
using Business.Dtos.Requests.MovieExclusiveLoungeRequests;
using Business.Dtos.Responses.MovieExclusiveLoungeResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class MovieExclusiveLoungeProfile : Profile
{
    public MovieExclusiveLoungeProfile()
    {
        CreateMap<MovieExclusiveLounge, CreateMovieExclusiveLoungeRequest>().ReverseMap();
        CreateMap<MovieExclusiveLounge, UpdateMovieExclusiveLoungeRequest>().ReverseMap();
        CreateMap<MovieExclusiveLounge, DeleteMovieExclusiveLoungeRequest>().ReverseMap();

        CreateMap<MovieExclusiveLounge, CreatedMovieExclusiveLoungeResponse>().ReverseMap();
        CreateMap<MovieExclusiveLounge, UpdatedMovieExclusiveLoungeResponse>().ReverseMap();
        CreateMap<MovieExclusiveLounge, DeletedMovieExclusiveLoungeResponse>().ReverseMap();

        CreateMap<IPaginate<MovieExclusiveLounge>, Paginate<GetMovieExclusiveLoungeListResponse>>().ReverseMap();
        CreateMap<MovieExclusiveLounge, GetMovieExclusiveLoungeListResponse>().ReverseMap();
    }
}
