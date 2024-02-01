using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IDirectorImageDal : IRepository<DirectorImage, Guid>, IAsyncRepository<DirectorImage, Guid>
{
}
