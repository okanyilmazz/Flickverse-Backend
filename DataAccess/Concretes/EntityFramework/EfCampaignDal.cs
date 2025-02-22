using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfCampaignDal : EfRepositoryBase<Campaign, Guid, FlickVerseContext>, ICampaignDal
{
    public EfCampaignDal(FlickVerseContext context) : base(context)
    {
    }
}

