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
    public class MovieImageManager : IMovieImageService
    {
        IMovieImageDal _movieImageDal;

        public MovieImageManager(IMovieImageDal movieImageDal)
        {
            _movieImageDal = movieImageDal;
        }

        public void Add(MovieImage movieImage)
        {
            _movieImageDal.Add(movieImage);
        }

        public void Delete(MovieImage movieImage)
        {
            _movieImageDal.Delete(movieImage);
        }

        public List<MovieImage> GetAll()
        {
            return _movieImageDal.GetAll();
        }

        public MovieImage GetById(int id)
        {
            return _movieImageDal.Get(x => x.Id == id);
        }

        public void Update(MovieImage movieImage)
        {
            _movieImageDal.Update(movieImage);
        }
    }
}
