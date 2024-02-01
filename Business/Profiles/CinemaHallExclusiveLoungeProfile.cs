using AutoMapper;
using Business.Dtos.Requests.CinemaHallExclusiveLoungeRequests;
using Business.Dtos.Responses.CinemaHallExclusiveLoungeResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class CinemaHallExclusiveLoungeExclusiveLoungeProfile : Profile
{
    public CinemaHallExclusiveLoungeExclusiveLoungeProfile()
    {
        CreateMap<CinemaHallExclusiveLounge, CreateCinemaHallExclusiveLoungeRequest>().ReverseMap();
        CreateMap<CinemaHallExclusiveLounge, UpdateCinemaHallExclusiveLoungeRequest>().ReverseMap();
        CreateMap<CinemaHallExclusiveLounge, DeleteCinemaHallExclusiveLoungeRequest>().ReverseMap();

        CreateMap<CinemaHallExclusiveLounge, CreatedCinemaHallExclusiveLoungeResponse>().ReverseMap();
        CreateMap<CinemaHallExclusiveLounge, UpdatedCinemaHallExclusiveLoungeResponse>().ReverseMap();
        CreateMap<CinemaHallExclusiveLounge, DeletedCinemaHallExclusiveLoungeResponse>().ReverseMap();

        CreateMap<IPaginate<CinemaHallExclusiveLounge>, Paginate<GetCinemaHallExclusiveLoungeListResponse>>().ReverseMap();
        CreateMap<CinemaHallExclusiveLounge, GetCinemaHallExclusiveLoungeListResponse>().ReverseMap();
    }
}