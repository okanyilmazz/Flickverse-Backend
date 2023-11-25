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
    public class MovieCategoryManager : IMovieCategoryService
    {
        IMovieCategoryDal _movieCategory;

        public MovieCategoryManager(IMovieCategoryDal movieCategory)
        {
            _movieCategory = movieCategory;
        }

        public IResult Add(MovieCategory movieCategory)
        {
            _movieCategory.Add(movieCategory);
            return new SuccessResult(Messages.CategoryAdded);

        }

        public IResult Delete(MovieCategory movieCategory)
        {
            _movieCategory.Delete(movieCategory);
            return new SuccessResult(Messages.CategoryDeleted);

        }

        public IDataResult<List<MovieCategory>> GetAll()
        {
            return new SuccessDataResult<List<MovieCategory>>(_movieCategory.GetAll(), Messages.CategoryListed);
        }

        public IDataResult<MovieCategory> GetById(int id)
        {
            return new SuccessDataResult<MovieCategory>(_movieCategory.Get(x => x.Id == id), Messages.CategoryListed);
        }

        public IResult Update(MovieCategory movieCategory)
        {
            _movieCategory.Update(movieCategory);
            return new SuccessResult(Messages.CategoryUpdated);
        }
    }
}
