using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MovieCastManager : IMovieCastService
    {
        IMovieCastDal _movieCastDal;

        public MovieCastManager(IMovieCastDal movieCastDal)
        {
            _movieCastDal = movieCastDal;
        }

        public IResult Add(MovieCast movieCast)
        {
            _movieCastDal.Add(movieCast);
            return new SuccessResult(Messages.CategoryAdded);

        }

        public IResult Delete(MovieCast movieCast)
        {
            _movieCastDal.Delete(movieCast);
            return new SuccessResult(Messages.CastDeleted);

        }

        public IDataResult<MovieCast> GetById(int id)
        {
            return new SuccessDataResult<MovieCast>(_movieCastDal.Get(x => x.Id == id), Messages.CastListed);
        }

        public IDataResult<List<MovieCast>> GetAll()
        {
            return new SuccessDataResult<List<MovieCast>>(_movieCastDal.GetAll(), Messages.CategoryListed);
        }

        public IResult Update(MovieCast movieCast)
        {
            _movieCastDal.Update(movieCast);
            return new SuccessResult(Messages.CastUpdated);

        }
    }
}
