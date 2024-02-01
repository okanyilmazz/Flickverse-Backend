using Business.Dtos.Requests.CinemaHallRequests;
using Business.Dtos.Responses.CinemaHallResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICinemaHallService
{
    Task<CreatedCinemaHallResponse> AddAsync(CreateCinemaHallRequest createCinemaHallRequest);
    Task<UpdatedCinemaHallResponse> UpdateAsync(UpdateCinemaHallRequest updateCinemaHallRequest);
    Task<DeletedCinemaHallResponse> DeleteAsync(DeleteCinemaHallRequest deleteCinemaHallRequest);
    Task<IPaginate<GetCinemaHallListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetCinemaHallListResponse> GetByIdAsync(Guid id);
}
