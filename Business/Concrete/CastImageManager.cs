using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CastImageManager : ICastImageService
    {
        ICastImageDal _castImageDal;

        public CastImageManager(ICastImageDal castImageDal)
        {
            _castImageDal = castImageDal;
        }

        public IResult Add(CastImage castImage)
        {
            _castImageDal.Add(castImage);
            return new SuccessResult(Messages.CastImageAdded);
        }

        public IResult Delete(CastImage castImage)
        {
            _castImageDal.Delete(castImage);
            return new SuccessResult(Messages.CastImageDeleted);

        }

        public IDataResult<CastImage> GetById(int id)
        {
            return new SuccessDataResult<CastImage>(_castImageDal.Get(x => x.Id == id), Messages.CastImageListed);
        }

        public IDataResult<List<CastImage>> GetAll()
        {
            return new SuccessDataResult<List<CastImage>>(_castImageDal.GetAll(), Messages.CastImageListed);
        }

        public IResult Update(CastImage castImage)
        {
            _castImageDal.Update(castImage);
            return new SuccessResult(Messages.CastImageUpdated);

        }
    }
}
