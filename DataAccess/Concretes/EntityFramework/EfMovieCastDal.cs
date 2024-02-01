using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfMovieCastDal : EfRepositoryBase<MovieCast, Guid, FlickVerseContext>, IMovieCastDal
{
    public EfMovieCastDal(FlickVerseContext context) : base(context)
    {
    }
}
