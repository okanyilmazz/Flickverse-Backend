using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IDistrictDal : IRepository<District, Guid>, IAsyncRepository<District, Guid>
{
}
