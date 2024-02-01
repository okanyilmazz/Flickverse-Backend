using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IMovieDal : IRepository<Movie, Guid>, IAsyncRepository<Movie, Guid>
{
}