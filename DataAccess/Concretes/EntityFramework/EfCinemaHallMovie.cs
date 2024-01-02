using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concretes.EntityFramework;

public class EfCinemaHallMovieDal : EfRepositoryBase<CinemaHallMovie, Guid, FlickVerseContext>, ICinemaHallMovieDal
{
    public EfCinemaHallMovieDal(FlickVerseContext context) : base(context)
    {
    }
}
