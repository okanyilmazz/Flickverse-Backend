using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface IAddressDal : IRepository<Address, Guid>, IAsyncRepository<Address, Guid>
{
}
