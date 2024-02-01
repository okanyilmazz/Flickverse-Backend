using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IAddressDal : IRepository<Address, Guid>, IAsyncRepository<Address, Guid>
{
}
