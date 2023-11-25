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
    public interface IMovieImageService
    {
        IDataResult<List<MovieImage>> GetAll();
        IDataResult<MovieImage> GetById(int id);
        IResult Add(MovieImage movieImage);
        IResult Update(MovieImage movieImage);
        IResult Delete(MovieImage movieImage);
    }
}
