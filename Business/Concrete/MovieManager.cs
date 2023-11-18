using Business.Abstract;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MovieManager : IMovieService
    {
        IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;   
        }

        public void Add(Movie movie)
        {
            _movieDal.Add(movie);
        }

        public void Delete(Movie movie)
        {
            _movieDal.Delete(movie);
        }

        public List<Movie> GetAll()
        {
            return _movieDal.GetAll();
        }

        public List<MovieDetailDto> GetAllCarDetail()
        {
            return _movieDal.GetMovieDetails();
        }

        public Movie GetById(int id)
        {
            return _movieDal.Get(x=>x.Id == id);
        }

        public void Update(Movie movie)
        {
            _movieDal.Update(movie);
        }
    }
}
