using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concretes.EntityFramework;

public class EfLanguageDal : EfRepositoryBase<Language, Guid, FlickVerseContext>, ILanguageDal
{
    public EfLanguageDal(FlickVerseContext context) : base(context)
    {
    }
}