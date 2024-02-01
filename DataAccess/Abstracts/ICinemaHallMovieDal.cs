using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICinemaHallMovieDal : IRepository<CinemaHallMovie, Guid>, IAsyncRepository<CinemaHallMovie, Guid>
{
}
