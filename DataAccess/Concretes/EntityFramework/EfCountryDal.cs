using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concretes.EntityFramework;

public class EfCountryDal : EfRepositoryBase<Country, Guid, FlickVerseContext>, ICountryDal
{
    public EfCountryDal(FlickVerseContext context) : base(context)
    {
    }
}
