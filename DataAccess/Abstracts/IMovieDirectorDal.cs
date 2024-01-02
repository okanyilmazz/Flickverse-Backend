using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts
{
    public interface IMovieDirectorDal : IRepository<MovieDirector, Guid>, IAsyncRepository<MovieDirector, Guid>
    {
    }
}