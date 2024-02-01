using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfCastImageDal : EfRepositoryBase<CastImage, Guid, FlickVerseContext>, ICastImageDal
{
    public EfCastImageDal(FlickVerseContext context) : base(context)
    {
    }
}
