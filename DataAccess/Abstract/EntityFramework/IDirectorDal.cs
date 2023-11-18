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
    public interface IDirectorDal : IEntityRepository<Director>
    {
        List<DirectorDetailDto> GetDirectorDetails(Expression<Func<DirectorDetailDto, bool>> filter = null);
    }
}
