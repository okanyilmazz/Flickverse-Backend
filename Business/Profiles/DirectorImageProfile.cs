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