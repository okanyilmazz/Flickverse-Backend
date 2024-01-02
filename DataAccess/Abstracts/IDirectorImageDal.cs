using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface IDirectorImageDal : IRepository<DirectorImage, Guid>, IAsyncRepository<DirectorImage, Guid>
{
}
