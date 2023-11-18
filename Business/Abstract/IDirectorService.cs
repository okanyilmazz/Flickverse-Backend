using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDirectorService
    {
        List<Director> GetAll();
        List<DirectorDetailDto> GetDirectorDetails();

        Director GetById(int id);
        void Add(Director director);
        void Update(Director director);
        void Delete(Director director);
    }
}
