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
    internal class CinemaMovieManager : ICinemaMovieService
    {
        ICinemaMovieDal _movieCinemaDal;

        public CinemaMovieManager(ICinemaMovieDal movieCinemaDal)
        {
            _movieCinemaDal = movieCinemaDal;
        }

        public IResult Add(CinemaMovie movieCinema)
        {
            _movieCinemaDal.Add(movieCinema);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(CinemaMovie movieCinema)
        {
            _movieCinemaDal.Delete(movieCinema);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CinemaMovie>> GetAll()
        {
            return new SuccessDataResult<List<CinemaMovie>>(_movieCinemaDal.GetAll(), Messages.Listed);

        }

        public IDataResult<CinemaMovie> GetById(int id)
        {
            return new SuccessDataResult<CinemaMovie>(_movieCinemaDal.Get(a => a.Id == id), Messages.Listed);

        }

        public IResult Update(CinemaMovie movieCinema)
        {
            _movieCinemaDal.Update(movieCinema);
            return new SuccessResult(Messages.Updated);
        }
    }
}
