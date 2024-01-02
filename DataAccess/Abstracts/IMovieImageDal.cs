using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts
{
    public interface IMovieImageDal : IRepository<MovieImage, Guid>, IAsyncRepository<MovieImage, Guid>
    {
    }
}