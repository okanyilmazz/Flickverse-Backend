using Business.Dtos.Requests.CinemaHallExclusiveLoungeRequests;
using Business.Dtos.Responses.CinemaHallExclusiveLoungeResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICinemaHallExclusiveLoungeService
{
    Task<CreatedCinemaHallExclusiveLoungeResponse> AddAsync(CreateCinemaHallExclusiveLoungeRequest createCinemaHallExclusiveLoungeRequest);
    Task<UpdatedCinemaHallExclusiveLoungeResponse> UpdateAsync(UpdateCinemaHallExclusiveLoungeRequest updateCinemaHallExclusiveLoungeRequest);
    Task<DeletedCinemaHallExclusiveLoungeResponse> DeleteAsync(DeleteCinemaHallExclusiveLoungeRequest deleteCinemaHallExclusiveLoungeRequest);
    Task<IPaginate<GetCinemaHallExclusiveLoungeListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetCinemaHallExclusiveLoungeListResponse> GetByIdAsync(Guid id);
}
