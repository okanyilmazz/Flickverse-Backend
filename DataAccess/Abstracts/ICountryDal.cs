using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface ICountryDal : IRepository<Country, Guid>, IAsyncRepository<Country, Guid>
{
}
