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
