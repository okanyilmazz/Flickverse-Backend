using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface ICastDal : IRepository<Cast, Guid>, IAsyncRepository<Cast, Guid>
{
}
