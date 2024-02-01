using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICityDal : IRepository<City, Guid>, IAsyncRepository<City, Guid>
{
}
