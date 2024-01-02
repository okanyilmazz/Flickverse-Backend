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

public class DirectorProfile : Profile
{
    public DirectorProfile()
    {
        CreateMap<Director, CreateDirectorRequest>().ReverseMap();
        CreateMap<Director, UpdateDirectorRequest>().ReverseMap();
        CreateMap<Director, DeleteDirectorRequest>().ReverseMap();

        CreateMap<Director, CreatedDirectorResponse>().ReverseMap();
        CreateMap<Director, UpdatedDirectorResponse>().ReverseMap();
        CreateMap<Director, DeletedDirectorResponse>().ReverseMap();

        CreateMap<IPaginate<Director>, Paginate<GetDirectorListResponse>>().ReverseMap();
        CreateMap<Director, GetDirectorListResponse>().ReverseMap();
    }
}
