using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMovieDirectorService
    {
        IDataResult<List<MovieDirector>> GetAll();
        IDataResult<MovieDirector> GetById(int id);
        IResult Add(MovieDirector movieDirector);
        IResult Update(MovieDirector movieDirector);
        IResult Delete(MovieDirector movieDirector);
    }
}
