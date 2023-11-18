using Business.Abstract;
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

        public void Add(MovieCategory movieCategory)
        {
            _movieCategory.Add(movieCategory);
        }

        public void Delete(MovieCategory movieCategory)
        {
            _movieCategory.Delete(movieCategory);
        }

        public List<MovieCategory> GetAll()
        {
            return _movieCategory.GetAll();
        }

        public MovieCategory GetById(int id)
        {
            return _movieCategory.Get(x => x.Id == id);
        }

        public void Update(MovieCategory movieCategory)
        {
            _movieCategory.Update(movieCategory);
        }
    }
}
