using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class ExclusiveLoungeBusinessRules : BaseBusinessRules
{
    IExclusiveLoungeDal _exclusiveLoungeDal;

    public ExclusiveLoungeBusinessRules(IExclusiveLoungeDal exclusiveLoungeDal)
    {
        _exclusiveLoungeDal = exclusiveLoungeDal;
    }

    public async Task IsExistsExclusiveLounge(Guid exclusiveLoungeId)
    {
        var result = await _exclusiveLoungeDal.GetAsync(
            predicate: a => a.Id == exclusiveLoungeId,
            enableTracking: false);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
}
