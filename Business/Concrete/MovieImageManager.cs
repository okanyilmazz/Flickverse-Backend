using Business.Abstract;
using Business.Constants;
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
    public class MovieImageManager : IMovieImageService
    {
        IMovieImageDal _movieImageDal;

        public MovieImageManager(IMovieImageDal movieImageDal)
        {
            _movieImageDal = movieImageDal;
        }

        public IResult Add(MovieImage movieImage)
        {
            _movieImageDal.Add(movieImage);
            return new SuccessResult(Messages.MovieImageAdded);
        }

        public IResult Delete(MovieImage movieImage)
        {
            _movieImageDal.Delete(movieImage);
            return new SuccessResult(Messages.MovieImageDeleted);
        }

        public IDataResult<List<MovieImage>> GetAll()
        {
            return new SuccessDataResult<List<MovieImage>>(_movieImageDal.GetAll(), Messages.MovieImageListed);
        }

        public IDataResult<MovieImage> GetById(int id)
        {
            return new SuccessDataResult<MovieImage>(_movieImageDal.Get(x => x.Id == id), Messages.MovieImageListed);
        }

        public IResult Update(MovieImage movieImage)
        {
            _movieImageDal.Update(movieImage);
            return new SuccessResult(Messages.MovieImageUpdated);
        }
    }
}
