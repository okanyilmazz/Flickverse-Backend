using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICastImageService
    {
        IDataResult<List<CastImage>> GetAll();
        IDataResult<CastImage> GetById(int id);
        IResult Add(CastImage castImage);
        IResult Update(CastImage castImage);
        IResult Delete(CastImage castImage);
    }
}
