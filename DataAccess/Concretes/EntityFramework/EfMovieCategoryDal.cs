using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concretes.EntityFramework;

public class EfMovieCategoryDal : EfRepositoryBase<MovieCategory, Guid, FlickVerseContext>, IMovieCategoryDal
{
    public EfMovieCategoryDal(FlickVerseContext context) : base(context)
    {
    }
}