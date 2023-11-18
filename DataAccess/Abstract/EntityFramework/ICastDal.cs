using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.EntityFramework
{
    public interface ICastDal : IEntityRepository<Cast>
    {
        List<CastDetailDto> GetCastDetails(Expression<Func<CastDetailDto, bool>> filter = null);
    }
}
