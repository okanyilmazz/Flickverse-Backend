using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICampaignDal : IRepository<Campaign, Guid>, IAsyncRepository<Campaign, Guid>
{
}

