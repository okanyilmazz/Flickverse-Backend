using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfCastDal : EfRepositoryBase<Cast, Guid, FlickVerseContext>, ICastDal
{
    public EfCastDal(FlickVerseContext context) : base(context)
    {
    }
}
