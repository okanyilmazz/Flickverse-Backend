using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMovieLoungeService
    {
        IDataResult<List<MovieLounge>> GetAll();
        IDataResult<MovieLounge> GetById(int id);
        IResult Add(MovieLounge movieLounge);
        IResult Update(MovieLounge movieLounge);
        IResult Delete(MovieLounge movieLounge);
    }
}
