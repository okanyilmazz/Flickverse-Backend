using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IMovieDirectorDal : IRepository<MovieDirector, Guid>, IAsyncRepository<MovieDirector, Guid>
{
}