using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface IExclusiveLoungeDal : IRepository<ExclusiveLounge, Guid>, IAsyncRepository<ExclusiveLounge, Guid>
{
}
