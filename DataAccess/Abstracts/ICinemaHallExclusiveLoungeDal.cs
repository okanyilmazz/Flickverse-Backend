using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface ICinemaHallExclusiveLoungeDal : IRepository<CinemaHallExclusiveLounge, Guid>, IAsyncRepository<CinemaHallExclusiveLounge, Guid>
{
}
