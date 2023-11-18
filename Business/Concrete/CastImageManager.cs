using Business.Abstract;
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

        public void Add(CastImage castImage)
        {
            _castImageDal.Add(castImage);
        }

        public void Delete(CastImage castImage)
        {
            _castImageDal.Delete(castImage);
        }

        public CastImage GetById(int id)
        {
            CastImage result = _castImageDal.Get(x => x.Id == id);
            return result;
        }

        public List<CastImage> GetAll()
        {
            var result = _castImageDal.GetAll();
            return result;
        }

        public void Update(CastImage castImage)
        {
            _castImageDal.Update(castImage);
        }
    }
}
