using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfMovieDal : EfRepositoryBase<Movie, Guid, FlickVerseContext>, IMovieDal
{
    public EfMovieDal(FlickVerseContext context) : base(context)
    {
    }
}