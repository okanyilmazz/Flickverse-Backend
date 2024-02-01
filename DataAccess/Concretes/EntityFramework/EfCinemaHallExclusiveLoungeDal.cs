using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfCinemaHallExclusiveLoungeDal : EfRepositoryBase<CinemaHallExclusiveLounge, Guid, FlickVerseContext>, ICinemaHallExclusiveLoungeDal
{
    public EfCinemaHallExclusiveLoungeDal(FlickVerseContext context) : base(context)
    {
    }
}
