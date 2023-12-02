using Core.Utilities.Results;
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
        IDataResult<List<Movie>> GetAll();
        IDataResult<List<MovieDetailsDto>> GetAllMovieDetails();
        IDataResult<Movie> GetById(int id);
        IResult Add(Movie movie);
        IResult Update(Movie movie);
        IResult Delete(Movie movie);
    }
}
