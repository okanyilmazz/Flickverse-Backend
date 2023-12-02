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
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public IResult Add(Address address)
        {
            _addressDal.Add(address);
            return new SuccessResult(Messages.AddressAdded);
        }

        public IResult Delete(Address address)
        {
            _addressDal.Delete(address);
            return new SuccessResult(Messages.AddressAdded);
        }

        public IDataResult<List<Address>> GetAll()
        {
            return new SuccessDataResult<List<Address>>(_addressDal.GetAll(), Messages.AddressListed);
        }

        public IDataResult<Address> GetById(int id)
        {
            return new SuccessDataResult<Address>(_addressDal.Get(a => a.Id == id), Messages.AddressListed);
        }

        public IResult Update(Address address)
        {
            _addressDal.Update(address);
            return new SuccessResult(Messages.AddressAdded);
        }
    }
}
