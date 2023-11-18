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
    public class CastManager : ICastService
    {
        ICastDal _castDal;

        public CastManager(ICastDal castDal)
        {
            _castDal = castDal;
        }

        public void Add(Cast cast)
        {
            _castDal.Add(cast);
        }

        public void Delete(Cast cast)
        {
            _castDal.Delete(cast);
        }

        public Cast GetById(int id)
        {
            var result = _castDal.Get(x=>x.Id==id);
            return result;
        }

        public List<Cast> GetAll()
        {
            var result = _castDal.GetAll();
            return result;
        }

        public void Update(Cast cast)
        {
            _castDal.Update(cast);
        }
    }
}
