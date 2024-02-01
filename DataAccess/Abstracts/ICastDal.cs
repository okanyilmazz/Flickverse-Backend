using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICastDal : IRepository<Cast, Guid>, IAsyncRepository<Cast, Guid>
{
}
