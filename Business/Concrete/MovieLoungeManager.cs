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
    public class MovieLoungeManager : IMovieLoungeService
    {
        IMovieLoungeDal _movieLoungeDal;
        public IResult Add(MovieLounge movieLounge)
        {
            _movieLoungeDal.Add(movieLounge);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(MovieLounge movieLounge)
        {
            _movieLoungeDal.Delete(movieLounge);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<MovieLounge>> GetAll()
        {
            return new SuccessDataResult<List<MovieLounge>>(_movieLoungeDal.GetAll(), Messages.Listed);
        }

        public IDataResult<MovieLounge> GetById(int id)
        {
            return new SuccessDataResult<MovieLounge>(_movieLoungeDal.Get(a => a.Id == id), Messages.Listed);
        }

        public IResult Update(MovieLounge movieLounge)
        {
            _movieLoungeDal.Update(movieLounge);
            return new SuccessResult(Messages.Updated);
        }
    }
}
