using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts
{
    public interface IMovieDal : IRepository<Movie, Guid>, IAsyncRepository<Movie, Guid>
    {
    }
}