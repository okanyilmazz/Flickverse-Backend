using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICinemaHallService
    {

        IDataResult<List<CinemaHall>> GetAll();
        IDataResult<CinemaHall> GetById(int id);
        IDataResult<List<CinemaHallDetailsDto>> GetCinemaHallDetails();
        IResult Add(CinemaHall cinemaHall);
        IResult Update(CinemaHall cinemaHall);
        IResult Delete(CinemaHall cinemaHall);
    }
}
