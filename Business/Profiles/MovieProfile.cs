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
        CreateMap<Movie, GetMovieListResponse>().ReverseMap();
    }
}
