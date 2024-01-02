using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concretes.EntityFramework;

public class EfCityDal : EfRepositoryBase<City, Guid, FlickVerseContext>, ICityDal
{
    public EfCityDal(FlickVerseContext context) : base(context)
    {
    }
}
