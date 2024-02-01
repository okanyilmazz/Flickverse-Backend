using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfDirectorDal : EfRepositoryBase<Director, Guid, FlickVerseContext>, IDirectorDal
{
    public EfDirectorDal(FlickVerseContext context) : base(context)
    {
    }
}
