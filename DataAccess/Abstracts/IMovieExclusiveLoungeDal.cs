using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IMovieExclusiveLoungeDal : IRepository<MovieExclusiveLounge, Guid>, IAsyncRepository<MovieExclusiveLounge, Guid>
{
}