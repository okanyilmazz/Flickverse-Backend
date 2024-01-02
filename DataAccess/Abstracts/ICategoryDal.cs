using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface ICategoryDal : IRepository<Category, Guid>, IAsyncRepository<Category, Guid>
{
}
