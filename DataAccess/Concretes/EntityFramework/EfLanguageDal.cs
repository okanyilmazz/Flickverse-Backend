using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfLanguageDal : EfRepositoryBase<Language, Guid, FlickVerseContext>, ILanguageDal
{
    public EfLanguageDal(FlickVerseContext context) : base(context)
    {
    }
}