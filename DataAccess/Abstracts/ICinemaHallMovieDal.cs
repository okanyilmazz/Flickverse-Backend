using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface ICinemaHallMovieDal : IRepository<CinemaHallMovie, Guid>, IAsyncRepository<CinemaHallMovie, Guid>
{
}
