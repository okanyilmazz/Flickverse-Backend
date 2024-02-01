using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IExclusiveLoungeDal : IRepository<ExclusiveLounge, Guid>, IAsyncRepository<ExclusiveLounge, Guid>
{
}
