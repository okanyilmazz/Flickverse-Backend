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
    public class DirectorImageManager : IDirectorImageService
    {
        IDirectorImageDal _directorImageDal;

        public DirectorImageManager(IDirectorImageDal directorImageDal)
        {
            _directorImageDal = directorImageDal;
        }

        public IResult Add(DirectorImage directorImage)
        {
            _directorImageDal.Add(directorImage);
            return new SuccessResult(Messages.DirectorImageAdded);

        }

        public IResult Delete(DirectorImage directorImage)
        {
            _directorImageDal.Delete(directorImage);
            return new SuccessResult(Messages.DirectorImageDeleted);

        }

        public IDataResult<DirectorImage> Get(int id)
        {
            return new SuccessDataResult<DirectorImage>( _directorImageDal.Get(x => x.Id == id),Messages.DirectorImageListed);
        }

        public IDataResult<List<DirectorImage>> GetAll()
        {
            return new SuccessDataResult<List<DirectorImage>>( _directorImageDal.GetAll(),Messages.DirectorImageListed);
        }

        public IResult Update(DirectorImage directorImage)
        {
            _directorImageDal.Update(directorImage);
            return new SuccessResult(Messages.DirectorImageUpdated);

        }
    }
}
