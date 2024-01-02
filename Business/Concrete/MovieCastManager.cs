using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;

namespace Business.Concrete;

public class MovieCastManager : IMovieCastService
{
    IMovieCastDal _movieCastDal;

    public MovieCastManager(IMovieCastDal movieCastDal)
    {
        _movieCastDal = movieCastDal;
    }

    public Task<CreatedMovieCastResponse> AddAsync(CreateMovieCastRequest createMovieCastRequest)
    {
        throw new NotImplementedException();
    }

    public Task<DeletedMovieCastResponse> DeleteAsync(DeleteMovieCastRequest deleteMovieCastRequest)
    {
        throw new NotImplementedException();
    }

    public Task<GetMovieCastListResponse> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IPaginate<GetMovieCastListResponse>> GetListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UpdatedMovieCastResponse> UpdateAsync(UpdateMovieCastRequest updateMovieCastRequest)
    {
        throw new NotImplementedException();
    }
}
