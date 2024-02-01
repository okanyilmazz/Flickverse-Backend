using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfMovieCategoryDal : EfRepositoryBase<MovieCategory, Guid, FlickVerseContext>, IMovieCategoryDal
{
    public EfMovieCategoryDal(FlickVerseContext context) : base(context)
    {
    }
}