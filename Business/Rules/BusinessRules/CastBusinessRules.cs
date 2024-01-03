using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class CastBusinessRules : BaseBusinessRules
{
    ICastDal _castDal;

    public CastBusinessRules(ICastDal castDal)
    {
        _castDal = castDal;
    }

    public async Task IsExistsCast(Guid castId)
    {
        var result = await _castDal.GetAsync(
            predicate: a => a.Id == castId);
        if (result == null)
        {
            throw new Exception(BusinessMessages.DataNotFound);
        }
    }
}