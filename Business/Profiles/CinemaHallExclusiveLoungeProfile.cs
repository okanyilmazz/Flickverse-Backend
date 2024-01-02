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