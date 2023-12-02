using Core.DataAccess.EntityFramework;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfExclusiveLoungeDal : EfEntityRepositoryBase<ExclusiveLounge, FlickVerseContext>, IExclusiveLoungeDal
    {
    }

}
