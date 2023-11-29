using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDirectorImageService
    {
        IDataResult<List<DirectorImage>> GetAll();
        IDataResult<DirectorImage> GetById(int id);
        IResult Add(DirectorImage directorImage);
        IResult Update(DirectorImage directorImage);
        IResult Delete(DirectorImage directorImage);
    }
}
