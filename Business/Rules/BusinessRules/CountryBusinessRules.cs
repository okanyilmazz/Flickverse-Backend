using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class CountryBusinessRules : BaseBusinessRules
{
    ICountryDal _countryDal;

    public CountryBusinessRules(ICountryDal countryDal)
    {
        _countryDal = countryDal;
    }

    public async Task IsExistsCountry(Guid countryId)
    {
        var result = await _countryDal.GetAsync(
            predicate: a => a.Id == countryId);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
}