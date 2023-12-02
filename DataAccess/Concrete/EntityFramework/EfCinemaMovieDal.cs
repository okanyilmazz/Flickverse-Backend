using Core.DataAccess.EntityFramework;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCinemaMovieDal : EfEntityRepositoryBase<CinemaMovie, FlickVerseContext>, ICinemaMovieDal
    {
    }

}
