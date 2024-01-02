using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface ICinemaHallDal : IRepository<CinemaHall, Guid>, IAsyncRepository<CinemaHall, Guid>
{
}
