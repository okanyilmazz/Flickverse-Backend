using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICinemaHallDal : IRepository<CinemaHall, Guid>, IAsyncRepository<CinemaHall, Guid>
{
}
