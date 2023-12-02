using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICinemaLoungeService
    {
        IDataResult<List<CinemaLounge>> GetAll();
        IDataResult<CinemaLounge> GetById(int id);
        IResult Add(CinemaLounge cinemaLounge);
        IResult Update(CinemaLounge cinemaLounge);
        IResult Delete(CinemaLounge cinemaLounge);
    }
}
