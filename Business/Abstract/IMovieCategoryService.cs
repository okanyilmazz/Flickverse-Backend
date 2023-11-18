using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMovieCategoryService
    {
        List<MovieCategory> GetAll();
        MovieCategory GetById(int id);
        void Add(MovieCategory movieCategory);
        void Update(MovieCategory movieCategory);
        void Delete(MovieCategory movieCategory);
    }
}
