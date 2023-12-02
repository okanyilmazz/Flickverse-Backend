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
    public class CinemaLoungeManager : ICinemaLoungeService
    {
        ICinemaLoungeDal _cinemaLoungeDal;

        public CinemaLoungeManager(ICinemaLoungeDal cinemaLoungeDal)
        {
            _cinemaLoungeDal = cinemaLoungeDal;
        }

        public IResult Add(CinemaLounge cinemaLounge)
        {
            _cinemaLoungeDal.Add(cinemaLounge);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(CinemaLounge cinemaLounge)
        {
            _cinemaLoungeDal.Delete(cinemaLounge);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CinemaLounge>> GetAll()
        {
            return new SuccessDataResult<List<CinemaLounge>>(_cinemaLoungeDal.GetAll(), Messages.Listed);
        }

        public IDataResult<CinemaLounge> GetById(int id)
        {
            return new SuccessDataResult<CinemaLounge>(_cinemaLoungeDal.Get(a => a.Id == id), Messages.Listed);
        }

        public IResult Update(CinemaLounge cinemaLounge)
        {
            _cinemaLoungeDal.Update(cinemaLounge);
            return new SuccessResult(Messages.Updated);
        }
    }
}
