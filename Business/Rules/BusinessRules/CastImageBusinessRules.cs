using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class CastImageBusinessRules : BaseBusinessRules
{
    ICastImageDal _castImageDal;

    public CastImageBusinessRules(ICastImageDal castImageDal)
    {
        _castImageDal = castImageDal;
    }

    public async Task IsExistsCastImage(Guid castImageId)
    {
        var result = await _castImageDal.GetAsync(
            predicate: a => a.Id == castImageId,
            enableTracking: false);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
}