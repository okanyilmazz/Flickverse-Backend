using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface ICastImageDal : IRepository<CastImage, Guid>, IAsyncRepository<CastImage, Guid>
{
}
