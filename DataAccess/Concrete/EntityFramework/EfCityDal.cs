using Core.DataAccess.EntityFramework;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCityDal : EfEntityRepositoryBase<City, FlickVerseContext>, ICityDal
    {
    }
}
