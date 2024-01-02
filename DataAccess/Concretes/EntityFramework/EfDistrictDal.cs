using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concretes.EntityFramework;

public class EfDistrictDal : EfRepositoryBase<District, Guid, FlickVerseContext>, IDistrictDal
{
    public EfDistrictDal(FlickVerseContext context) : base(context)
    {
    }
}
