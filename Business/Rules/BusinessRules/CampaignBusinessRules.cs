using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;

namespace Business.Rules.BusinessRules;

public class CampaignBusinessRules : BaseBusinessRules
{
    ICampaignDal _campaignDal;
    public CampaignBusinessRules(ICampaignDal campaignDal)
    {
        _campaignDal = campaignDal;
    }

    public async Task IsExistsCampaign(Guid id)
    {
        var result = await _campaignDal.GetAsync(predicate: c => c.Id == id, enableTracking: false);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);

        }
    }
}