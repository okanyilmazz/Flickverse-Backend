using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class DirectorImageBusinessRules : BaseBusinessRules
{
    IDirectorImageDal _directorImageDal;

    public DirectorImageBusinessRules(IDirectorImageDal directorImageDal)
    {
        _directorImageDal = directorImageDal;
    }

    public async Task IsExistsDirectorImage(Guid directorImageId)
    {
        var result = await _directorImageDal.GetAsync(
            predicate: a => a.Id == directorImageId,
            enableTracking: false);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
}
