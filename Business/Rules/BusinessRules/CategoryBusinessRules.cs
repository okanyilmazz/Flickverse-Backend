using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class CategoryBusinessRules : BaseBusinessRules
{
    ICategoryDal _categoryDal;

    public CategoryBusinessRules(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public async Task IsExistsCategory(Guid categoryId)
    {
        var result = await _categoryDal.GetAsync(
            predicate: a => a.Id == categoryId);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
}