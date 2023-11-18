using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.EntityFramework
{
    public interface IMovieDal : IEntityRepository<Movie>
    {

        List<MovieDetailsDTO> GetMovieDetails(Expression<Func<MovieDetailsDTO, bool>> filter = null);

    }
}
