using AutoMapper;
using Business.Dtos.Requests.CinemaHallRequests;
using Business.Dtos.Responses.CinemaHallResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class CinemaHallProfile : Profile
{
    public CinemaHallProfile()
    {
        CreateMap<CinemaHall, CreateCinemaHallRequest>().ReverseMap();
        CreateMap<CinemaHall, UpdateCinemaHallRequest>().ReverseMap();
        CreateMap<CinemaHall, DeleteCinemaHallRequest>().ReverseMap();

        CreateMap<CinemaHall, CreatedCinemaHallResponse>().ReverseMap();
        CreateMap<CinemaHall, UpdatedCinemaHallResponse>().ReverseMap();
        CreateMap<CinemaHall, DeletedCinemaHallResponse>().ReverseMap();

        CreateMap<IPaginate<CinemaHall>, Paginate<GetCinemaHallListResponse>>().ReverseMap();
        CreateMap<CinemaHall, GetCinemaHallListResponse>().ReverseMap();
    }
}