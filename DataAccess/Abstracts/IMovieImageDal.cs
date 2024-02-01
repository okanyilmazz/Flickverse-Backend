using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IMovieImageDal : IRepository<MovieImage, Guid>, IAsyncRepository<MovieImage, Guid>
{
}