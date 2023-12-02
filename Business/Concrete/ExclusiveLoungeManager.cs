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
    public class ExclusiveLoungeManager : IExclusiveLoungeService
    {
        IExclusiveLoungeDal _exclusiveLoungeDal;

        public ExclusiveLoungeManager(IExclusiveLoungeDal exclusiveLoungeDal)
        {
            _exclusiveLoungeDal = exclusiveLoungeDal;
        }

        public IResult Add(ExclusiveLounge exclusiveLounge)
        {
            _exclusiveLoungeDal.Add(exclusiveLounge);
            return new SuccessResult(Messages.ExclusiveLoungeAdded);
        }

        public IResult Delete(ExclusiveLounge exclusiveLounge)
        {
            _exclusiveLoungeDal.Delete(exclusiveLounge);
            return new SuccessResult(Messages.ExclusiveLoungeDeleted);
        }

        public IDataResult<List<ExclusiveLounge>> GetAll()
        {
            return new SuccessDataResult<List<ExclusiveLounge>>(_exclusiveLoungeDal.GetAll(), Messages.ExclusiveLoungeListed);
        }

        public IDataResult<ExclusiveLounge> GetById(int id)
        {
            return new SuccessDataResult<ExclusiveLounge>(_exclusiveLoungeDal.Get(a => a.Id == id), Messages.ExclusiveLoungeListed);
        }

        public IResult Update(ExclusiveLounge exclusiveLounge)
        {
            _exclusiveLoungeDal.Update(exclusiveLounge);
            return new SuccessResult(Messages.ExclusiveLoungeUpdated);
        }
    }
}
