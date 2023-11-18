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
        List<DirectorImage> GetAll();
        DirectorImage Get(int id);
        void Add(DirectorImage directorImage);
        void Update(DirectorImage directorImage);
        void Delete(DirectorImage directorImage);
    }
}
