using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concretes.EntityFramework;

public class EfMovieDirectorDal : EfRepositoryBase<MovieDirector, Guid, FlickVerseContext>, IMovieDirectorDal
{
    public EfMovieDirectorDal(FlickVerseContext context) : base(context)
    {
    }
}