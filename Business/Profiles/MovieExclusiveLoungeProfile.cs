﻿using AutoMapper;
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
