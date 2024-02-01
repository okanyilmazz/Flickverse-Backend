using Business.Dtos.Requests.CinemaHallMovieRequests;
using Business.Dtos.Responses.CinemaHallMovieResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICinemaHallMovieService
{
    Task<CreatedCinemaHallMovieResponse> AddAsync(CreateCinemaHallMovieRequest createCinemaHallMovieRequest);
    Task<UpdatedCinemaHallMovieResponse> UpdateAsync(UpdateCinemaHallMovieRequest updateCinemaHallMovieRequest);
    Task<DeletedCinemaHallMovieResponse> DeleteAsync(DeleteCinemaHallMovieRequest deleteCinemaHallMovieRequest);
    Task<IPaginate<GetCinemaHallMovieListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetCinemaHallMovieListResponse> GetByIdAsync(Guid id);
}
