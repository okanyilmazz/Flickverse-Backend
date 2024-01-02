using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface ICinemaHallService
{

    Task<CreatedCinemaHallResponse> AddAsync(CreateCinemaHallRequest createCinemaHallRequest);
    Task<UpdatedCinemaHallResponse> UpdateAsync(UpdateCinemaHallRequest updateCinemaHallRequest);
    Task<DeletedCinemaHallResponse> DeleteAsync(DeleteCinemaHallRequest deleteCinemaHallRequest);
    Task<IPaginate<GetCinemaHallListResponse>> GetListAsync();
    Task<GetCinemaHallListResponse> GetByIdAsync(Guid id);
}
