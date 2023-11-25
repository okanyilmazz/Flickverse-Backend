using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICastService
    {
        IDataResult<List<Cast>> GetAll();
        IDataResult<List<CastDetailDto>> GetCastDetails();
        IDataResult<Cast> GetById(int id);
        IResult Add(Cast cast);
        IResult Update(Cast cast);
        IResult Delete(Cast cast);
    }
}
