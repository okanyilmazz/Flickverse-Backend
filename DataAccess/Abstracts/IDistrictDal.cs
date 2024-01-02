using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface IDistrictDal : IRepository<District, Guid>, IAsyncRepository<District, Guid>
{
}
