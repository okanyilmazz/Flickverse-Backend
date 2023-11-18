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
    public class DirectorImageManager : IDirectorImageService
    {
        IDirectorImageDal _directorImageDal;

        public DirectorImageManager(IDirectorImageDal directorImageDal)
        {
            _directorImageDal = directorImageDal;
        }

        public void Add(DirectorImage directorImage)
        {
            _directorImageDal.Add(directorImage);
        }

        public void Delete(DirectorImage directorImage)
        {
            _directorImageDal.Delete(directorImage);
        }

        public DirectorImage Get(int id)
        {
            return _directorImageDal.Get(x => x.Id == id);
        }

        public List<DirectorImage> GetAll()
        {
            return _directorImageDal.GetAll();
        }

        public void Update(DirectorImage directorImage)
        {
            _directorImageDal.Update(directorImage);
        }
    }
}
