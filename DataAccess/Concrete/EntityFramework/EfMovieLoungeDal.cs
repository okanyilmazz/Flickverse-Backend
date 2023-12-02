using Core.DataAccess.EntityFramework;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMovieLoungeDal : EfEntityRepositoryBase<MovieLounge, FlickVerseContext>, IMovieLoungeDal
    {
    }

}
