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
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public IResult Add(Country country)
        {
            _countryDal.Add(country);
            return new SuccessResult(Messages.CountryAdded);
        }

        public IResult Delete(Country country)
        {
            _countryDal.Delete(country);
            return new SuccessResult(Messages.CountryDeleted);
        }

        public IDataResult<List<Country>> GetAll()
        {
            return new SuccessDataResult<List<Country>>(_countryDal.GetAll(), Messages.CountryListed);
        }

        public IDataResult<Country> GetById(int id)
        {
            return new SuccessDataResult<Country>(_countryDal.Get(c => c.Id == id), Messages.CountryListed);

        }

        public IResult Update(Country country)
        {
            _countryDal.Update(country);
            return new SuccessResult(Messages.CountryUpdated);
        }
    }
}
