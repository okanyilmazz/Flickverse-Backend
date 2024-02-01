using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IMovieCategoryDal : IRepository<MovieCategory, Guid>, IAsyncRepository<MovieCategory, Guid>
{
}