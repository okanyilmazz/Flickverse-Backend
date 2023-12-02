using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IExclusiveLoungeService
    {
        IDataResult<List<ExclusiveLounge>> GetAll();
        IDataResult<ExclusiveLounge> GetById(int id);
        IResult Add(ExclusiveLounge exclusiveLounge);
        IResult Update(ExclusiveLounge exclusiveLounge);
        IResult Delete(ExclusiveLounge exclusiveLounge);
    }
}
