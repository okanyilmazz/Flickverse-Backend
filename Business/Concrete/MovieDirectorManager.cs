using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MovieDirectorManager : IMovieDirectorService
    {
        IMovieDirectorDal _movieDirectorDal;

        public MovieDirectorManager(IMovieDirectorDal movieDirectorDal)
        {
            _movieDirectorDal = movieDirectorDal;
        }

        public IResult Add(MovieDirector movieDirector)
        {
            _movieDirectorDal.Add(movieDirector);
            return new SuccessResult();
        }

        public IResult Delete(MovieDirector movieDirector)
        {
            _movieDirectorDal.Delete(movieDirector);
            return new SuccessResult();
        }

        public IDataResult<List<MovieDirector>> GetAll()
        {
            return new SuccessDataResult<List<MovieDirector>>(_movieDirectorDal.GetAll());
        }

        public IDataResult<MovieDirector> GetById(int id)
        {
            return new SuccessDataResult<MovieDirector>(_movieDirectorDal.Get(m => m.Id == id));
        }

        public IResult Update(MovieDirector movieDirector)
        {
            _movieDirectorDal.Update(movieDirector);
            return new SuccessResult();
        }
    }
}
