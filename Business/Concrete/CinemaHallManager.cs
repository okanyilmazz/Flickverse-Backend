using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CinemaHallManager : ICinemaHallService
    {
        ICinemaHallDal _cinemaHallDal;

        public CinemaHallManager(ICinemaHallDal cinemaHallDal)
        {
            _cinemaHallDal = cinemaHallDal;
        }

        public IResult Add(CinemaHall cinemaHall)
        {
            _cinemaHallDal.Add(cinemaHall);
            return new SuccessResult(Messages.CinemaHallAdded);
        }

        public IResult Delete(CinemaHall cinemaHall)
        {
            _cinemaHallDal.Delete(cinemaHall);
            return new SuccessResult(Messages.CinemaHallDeleted);
        }

        public IDataResult<List<CinemaHall>> GetAll()
        {
            return new SuccessDataResult<List<CinemaHall>>(_cinemaHallDal.GetAll(), Messages.CinemaHallListed);
        }

        public IDataResult<CinemaHall> GetById(int id)
        {
            return new SuccessDataResult<CinemaHall>(_cinemaHallDal.Get(a => a.Id == id), Messages.CinemaHallListed);
        }

        public IDataResult<List<CinemaHallDetailsDto>> GetCinemaHallDetails()
        {
            return new SuccessDataResult<List<CinemaHallDetailsDto>>(_cinemaHallDal.GetCinemaDetails(),Messages.CinemaHallListed);
        }

        public IResult Update(CinemaHall cinemaHall)
        {
            _cinemaHallDal.Update(cinemaHall);
            return new SuccessResult(Messages.CinemaHallUpdated);
        }
    }
}
