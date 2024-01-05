using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface ICinemaHallExclusiveLoungeService
{
    Task<CreatedCinemaHallExclusiveLoungeResponse> AddAsync(CreateCinemaHallExclusiveLoungeRequest createCinemaHallExclusiveLoungeRequest);
    Task<UpdatedCinemaHallExclusiveLoungeResponse> UpdateAsync(UpdateCinemaHallExclusiveLoungeRequest updateCinemaHallExclusiveLoungeRequest);
    Task<DeletedCinemaHallExclusiveLoungeResponse> DeleteAsync(DeleteCinemaHallExclusiveLoungeRequest deleteCinemaHallExclusiveLoungeRequest);
    Task<IPaginate<GetCinemaHallExclusiveLoungeListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetCinemaHallExclusiveLoungeListResponse> GetByIdAsync(Guid id);
}
