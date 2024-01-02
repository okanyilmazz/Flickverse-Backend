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
