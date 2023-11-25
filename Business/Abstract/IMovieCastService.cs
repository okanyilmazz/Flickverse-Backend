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
   public interface IMovieCastService
    {
        IDataResult<List<MovieCast>> GetAll();
        IDataResult<MovieCast> GetById(int id);
        IResult Add(MovieCast movieCast);
        IResult Update(MovieCast movieCast);
        IResult Delete(MovieCast movieCast);
    }
}
