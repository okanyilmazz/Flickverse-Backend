using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMovieService
    {
        List<Movie> GetAll();
        List<MovieDetailsDTO> GetAllCarDetail();
        Movie GetById(int id);

        void Add(Movie movie);
        void Update(Movie movie);
        void Delete(Movie movie);
    }
}
