using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CountyManager : ICountyService
    {
        ICountyDal _countyDal;

        public CountyManager(ICountyDal countyDal)
        {
            _countyDal = countyDal;
        }

        public IResult Add(County county)
        {
            _countyDal.Add(county);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(County county)
        {
            _countyDal.Delete(county);
            return new SuccessResult(Messages.CastDeleted);
        }

        public IDataResult<List<County>> GetAll()
        {
            return new SuccessDataResult<List<County>>(_countyDal.GetAll(), Messages.CastListed);
        }

        public IDataResult<County> GetById(int id)
        {
            return new SuccessDataResult<County>(_countyDal.Get(x => x.Id == id), Messages.CastListed);
        }

        public IResult Update(County county)
        {
            _countyDal.Update(county);
            return new SuccessResult(Messages.CastUpdated);
        }
    }
}
