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
        List<MovieImage> GetAll();
        MovieImage GetById(int id);
        void Add(MovieImage movieImage);
        void Update(MovieImage movieImage);
        void Delete(MovieImage movieImage);
    }
}
