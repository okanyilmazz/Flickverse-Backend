using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICountryService
    {
        IDataResult<List<Country>> GetAll();
        IDataResult<Country> GetById(int id);
        IResult Add(Country country);
        IResult Update(Country country);
        IResult Delete(Country country);

    }
}
