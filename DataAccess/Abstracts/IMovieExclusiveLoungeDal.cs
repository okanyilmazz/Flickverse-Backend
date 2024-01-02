using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts
{
    public interface IMovieExclusiveLoungeDal : IRepository<MovieExclusiveLounge, Guid>, IAsyncRepository<MovieExclusiveLounge, Guid>
    {
    }
}