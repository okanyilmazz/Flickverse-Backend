using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class CityBusinessRules : BaseBusinessRules
{
    ICityDal _cityDal;

    public CityBusinessRules(ICityDal cityDal)
    {
        _cityDal = cityDal;
    }

    public async Task IsExistsCity(Guid cityId)
    {
        var result = await _cityDal.GetAsync(
            predicate: a => a.Id == cityId);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
}
