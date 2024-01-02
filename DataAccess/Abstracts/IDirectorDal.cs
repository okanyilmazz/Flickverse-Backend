using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface IDirectorDal : IRepository<Director, Guid>, IAsyncRepository<Director, Guid>
{
}
