using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfMovieImageDal : EfRepositoryBase<MovieImage, Guid, FlickVerseContext>, IMovieImageDal
{
    public EfMovieImageDal(FlickVerseContext context) : base(context)
    {
    }
}