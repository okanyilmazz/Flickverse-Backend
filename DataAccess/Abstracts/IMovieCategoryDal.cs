using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts
{
    public interface IMovieCategoryDal : IRepository<MovieCategory, Guid>, IAsyncRepository<MovieCategory, Guid>
    {
    }
}