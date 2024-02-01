using AutoMapper;
using Business.Dtos.Requests.DirectorRequests;
using Business.Dtos.Responses.DirectorResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;

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
