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