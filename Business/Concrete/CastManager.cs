using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CastManager : ICastService
    {
        ICastDal _castDal;

        public CastManager(ICastDal castDal)
        {
            _castDal = castDal;
        }

        public IResult Add(Cast cast)
        {
            _castDal.Add(cast);

            return new SuccessResult(Messages.CastAdded);
        }

        public IResult Delete(Cast cast)
        {
            _castDal.Delete(cast);
            return new SuccessResult(Messages.CastDeleted);

        }

        public IDataResult<Cast> GetById(int id)
        {
            return new SuccessDataResult<Cast>(_castDal.Get(x => x.Id == id), Messages.CastListed);
        }

        public IDataResult<List<Cast>> GetAll()
        {
            return new SuccessDataResult<List<Cast>>(_castDal.GetAll(), Messages.CastListed);
        }

        public IResult Update(Cast cast)
        {
            _castDal.Update(cast);
            return new SuccessResult(Messages.CastUpdated);

        }

        public IDataResult<List<CastDetailDto>> GetCastDetails()
        {
            return new SuccessDataResult<List<CastDetailDto>>(_castDal.GetCastDetails(), Messages.CastListed);

        }
    }
}
