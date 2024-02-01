using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IMovieCastDal : IRepository<MovieCast, Guid>, IAsyncRepository<MovieCast, Guid>
{
}