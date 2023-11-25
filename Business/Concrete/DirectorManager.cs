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
    public class DirectorManager : IDirectorService
    {
        IDirectorDal _directorDal;

        public DirectorManager(IDirectorDal directorDal)
        {
            _directorDal = directorDal;
        }

        public IResult Add(Director director)
        {
            _directorDal.Add(director);
            return new SuccessResult(Messages.DirectorAdded);

        }

        public IResult Delete(Director director)
        {
            _directorDal.Delete(director);
            return new SuccessResult(Messages.DirectorDeleted);

        }

        public IDataResult<Director> GetById(int id)
        {
            return new SuccessDataResult<Director>(_directorDal.Get(x => x.Id == id), Messages.DirectorListed);
        }

        public IDataResult<List<Director>> GetAll()
        {
            return new SuccessDataResult<List<Director>>(_directorDal.GetAll(), Messages.DirectorListed);
        }

        public IResult Update(Director director)
        {
            _directorDal.Update(director);
            return new SuccessResult(Messages.DirectorUpdated);

        }

        public IDataResult<List<DirectorDetailDto>> GetDirectorDetails()
        {
            return new SuccessDataResult<List<DirectorDetailDto>>(_directorDal.GetDirectorDetails(), Messages.DirectorListed);
        }
    }
}
