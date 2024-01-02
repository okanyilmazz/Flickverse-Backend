using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface ICityDal : IRepository<City, Guid>, IAsyncRepository<City, Guid>
{
}
