using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICinemaMovieService
    {
        IDataResult<List<CinemaMovie>> GetAll();
        IDataResult<CinemaMovie> GetById(int id);
        IResult Add(CinemaMovie movieCinema);
        IResult Update(CinemaMovie movieCinema);
        IResult Delete(CinemaMovie movieCinema);
    }
}
