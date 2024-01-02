using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface ICinemaHallMovieService
{
    Task<CreatedCinemaHallMovieResponse> AddAsync(CreateCinemaHallMovieRequest createCinemaHallMovieRequest);
    Task<UpdatedCinemaHallMovieResponse> UpdateAsync(UpdateCinemaHallMovieRequest updateCinemaHallMovieRequest);
    Task<DeletedCinemaHallMovieResponse> DeleteAsync(DeleteCinemaHallMovieRequest deleteCinemaHallMovieRequest);
    Task<IPaginate<GetCinemaHallMovieListResponse>> GetListAsync();
    Task<GetCinemaHallMovieListResponse> GetByIdAsync(Guid id);
}
