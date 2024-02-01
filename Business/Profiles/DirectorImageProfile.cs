using AutoMapper;
using Business.Dtos.Requests.DirectorImageRequests;
using Business.Dtos.Responses.DirectorImageResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class DirectorImageImageProfile : Profile
{
    public DirectorImageImageProfile()
    {
        CreateMap<DirectorImage, CreateDirectorImageRequest>().ReverseMap();
        CreateMap<DirectorImage, UpdateDirectorImageRequest>().ReverseMap();
        CreateMap<DirectorImage, DeleteDirectorImageRequest>().ReverseMap();

        CreateMap<DirectorImage, CreatedDirectorImageResponse>().ReverseMap();
        CreateMap<DirectorImage, UpdatedDirectorImageResponse>().ReverseMap();
        CreateMap<DirectorImage, DeletedDirectorImageResponse>().ReverseMap();

        CreateMap<IPaginate<DirectorImage>, Paginate<GetDirectorImageListResponse>>().ReverseMap();
        CreateMap<DirectorImage, GetDirectorImageListResponse>().ReverseMap();
    }
}