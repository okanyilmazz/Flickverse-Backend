using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class DistrictBusinessRules : BaseBusinessRules
{
    IDistrictDal _districtDal;

    public DistrictBusinessRules(IDistrictDal districtDal)
    {
        _districtDal = districtDal;
    }

    public async Task IsExistsDistrict(Guid districtId)
    {
        var result = await _districtDal.GetAsync(
            predicate: a => a.Id == districtId);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
}
