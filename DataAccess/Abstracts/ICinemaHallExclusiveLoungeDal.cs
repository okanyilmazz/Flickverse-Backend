using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICinemaHallExclusiveLoungeDal : IRepository<CinemaHallExclusiveLounge, Guid>, IAsyncRepository<CinemaHallExclusiveLounge, Guid>
{
}
