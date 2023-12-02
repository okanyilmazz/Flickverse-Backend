using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICountyService
    {
        IDataResult<List<County>> GetAll();
        IDataResult<County> GetById(int id);
        IResult Add(County county);
        IResult Update(County county);
        IResult Delete(County county);
    }
}
