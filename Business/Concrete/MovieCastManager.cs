using Business.Abstract;
using DataAccess.Abstract.EntityFramework;
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

        public void Add(MovieCast movieCast)
        {
           _movieCastDal.Add(movieCast);
        }

        public void Delete(MovieCast movieCast)
        {
            _movieCastDal.Delete(movieCast);
        }

        public MovieCast GetById(int id)
        {
           return _movieCastDal.Get(x=>x.Id == id);
        }

        public List<MovieCast> GetAll()
        {
            return _movieCastDal.GetAll();
        }

        public void Update(MovieCast movieCast)
        {
            _movieCastDal.Update(movieCast);
        }
    }
}
