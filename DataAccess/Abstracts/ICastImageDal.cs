using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICastImageDal : IRepository<CastImage, Guid>, IAsyncRepository<CastImage, Guid>
{
}
