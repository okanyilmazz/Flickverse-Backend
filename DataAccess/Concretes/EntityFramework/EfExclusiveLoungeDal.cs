using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concretes.EntityFramework;

public class EfExclusiveLoungeDal : EfRepositoryBase<ExclusiveLounge, Guid, FlickVerseContext>, IExclusiveLoungeDal
{
    public EfExclusiveLoungeDal(FlickVerseContext context) : base(context)
    {
    }
}
