using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfCinemaHallDal : EfRepositoryBase<CinemaHall, Guid, FlickVerseContext>, ICinemaHallDal
{
    public EfCinemaHallDal(FlickVerseContext context) : base(context)
    {
    }
}
