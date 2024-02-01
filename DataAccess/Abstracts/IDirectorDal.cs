using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IDirectorDal : IRepository<Director, Guid>, IAsyncRepository<Director, Guid>
{
}
