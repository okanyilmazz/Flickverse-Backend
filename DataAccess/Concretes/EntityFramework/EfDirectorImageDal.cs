using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfDirectorImageDal : EfRepositoryBase<DirectorImage, Guid, FlickVerseContext>, IDirectorImageDal
{
    public EfDirectorImageDal(FlickVerseContext context) : base(context)
    {
    }
}
