using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts
{
    public interface IMovieCastDal : IRepository<MovieCast, Guid>, IAsyncRepository<MovieCast, Guid>
    {
    }
}