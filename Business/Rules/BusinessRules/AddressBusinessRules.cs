using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class AddressBusinessRules : BaseBusinessRules
{
    IAddressDal _addressDal;

    public AddressBusinessRules(IAddressDal addressDal)
    {
        _addressDal = addressDal;
    }

    public async Task IsExistsAddress(Guid addressId)
    {
        var result = await _addressDal.GetAsync(
            predicate: a => a.Id == addressId);
        if (result == null)
        {
            throw new Exception(BusinessMessages.DataNotFound);
        }
    }
}
