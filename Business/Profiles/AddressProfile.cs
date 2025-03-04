﻿using AutoMapper;
using Business.Dtos.Requests.AddressRequests;
using Business.Dtos.Responses.AddressResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<Address, CreateAddressRequest>().ReverseMap();
        CreateMap<Address, UpdateAddressRequest>().ReverseMap();
        CreateMap<Address, DeleteAddressRequest>().ReverseMap();

        CreateMap<Address, CreatedAddressResponse>().ReverseMap();
        CreateMap<Address, UpdatedAddressResponse>().ReverseMap();
        CreateMap<Address, DeletedAddressResponse>().ReverseMap();

        CreateMap<IPaginate<Address>, Paginate<GetAddressListResponse>>().ReverseMap();
        CreateMap<Address, GetAddressListResponse>().ReverseMap();
    }
}
